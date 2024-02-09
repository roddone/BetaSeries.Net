using BetaSeries.Net.Core;
using BetaSeries.Net.Exceptions;
using BetaSeries.Net.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BetaSeries.Net
{
    public static class RestHelper
    {
        #region Private Fields

        private static string _apiBaseUri = "https://api.betaseries.com/";
        private static string _apiVersion = "3.0";
        private static string _developerKey = null;
        private static string _userAgent = "BetaSeries.Net/0.0.1";
        private static Dictionary<Type, string> _urlByType = new Dictionary<Type, string>();
        private static string _userToken = null;

        #endregion Private Fields

        #region Public Constructors

        static RestHelper()
        {
            //TODO : find all urls by type
            Type restAttributeType = typeof(RestAttribute);

            typeof(RestHelper).Assembly.GetTypes().ToList().ForEach(t =>
            {
                if (t.GetCustomAttributes(restAttributeType, false)?.FirstOrDefault() is RestAttribute attr)
                {
                    if (!string.IsNullOrWhiteSpace(attr.Url))
                    {
                        _urlByType.Add(t, attr.Url);
                    }
                    else
                    {
                        //default: class name
                        _urlByType.Add(t, t.FullName.Remove(0, t.Namespace.Length + 1).ToLower().Replace("+", "/"));
                    }
                }
            });
        }

        #endregion Public Constructors

        #region Public Methods

        public static string HashPassword(string input)
        {
            // step 1, calculate MD5 hash from input
            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public static async Task<dynamic> Delete<T>(dynamic parameters) where T : class
        {
            string url = GetUrlOrThrow(typeof(T));
            url += DynamicToQueryString(parameters);

            return await Request<dynamic>(AllowedHttpVerbs.Delete, url, parameters);
        }

        public static async Task<dynamic> Get<T>(dynamic parameters = null) where T : class
        {
            string url = GetUrlOrThrow(typeof(T));
            url += DynamicToQueryString(parameters);

            return await Request<dynamic>(AllowedHttpVerbs.Get, url, parameters);
        }

        public static async Task<dynamic> Post<T>(dynamic parameters) where T : class
        {
            string url = GetUrlOrThrow(typeof(T));

            return await Request<dynamic>(AllowedHttpVerbs.Post, url, parameters);
        }

        public static async Task<dynamic> Put<T>(dynamic parameters) where T : class
        {
            string url = GetUrlOrThrow(typeof(T));

            return await Request<dynamic>(AllowedHttpVerbs.Put, url, parameters);
        }

        public static void RegisterDeveloperKey(string key)
        {
            _developerKey = key;
            OAUTH.RegisterDeveloperKey(key);
        }

        public static void RegisterDeveloperKey(string key, string oauthsecret)
        {
            RegisterDeveloperKey(key);
            OAUTH.RegisterOAuthSecret(oauthsecret);
        }

        public static void RegisterUserToken(string token)
        {
            _userToken = token;
        }

        public static void SetUserAgent(string userAgent)
        {
            _userAgent = userAgent;
        }
        #endregion Public Methods

        #region Private Methods

        private static Dictionary<string, object> DynamicToPostParam(dynamic d)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            foreach (var prop in d.GetType().GetProperties())
            {
                string propName = prop.Name;
                object value = prop.GetValue(d, null);

                dict.Add(propName, value);
            }

            return dict;
        }

        private static string DynamicToQueryString(dynamic d)
        {
            if (d != null)
            {
                string output = "?";
                List<string> parameters = new List<string>();

                foreach (var prop in d.GetType().GetProperties())
                {
                    string propName = prop.Name;
                    object value = prop.GetValue(d, null);
                    parameters.Add($"{propName}={value.ToString()}");
                }

                output += string.Join("&", parameters);

                return output;
            }

            return string.Empty;
        }

        private static string GetUrlOrThrow(Type type)
        {
            if (_urlByType.TryGetValue(type, out string url))
            {
                return url;
            }
            else
            {
                throw new RouteNotFoundException(type);
            }
        }

        private static async Task<dynamic> Request<T>(AllowedHttpVerbs method, string url, dynamic parameters)
        {
            if (string.IsNullOrWhiteSpace(_developerKey))
            {
                throw new NoDeveloperKeyException();
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiBaseUri);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Key", _developerKey);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Version", _apiVersion);
                client.DefaultRequestHeaders.UserAgent.ParseAdd(_userAgent);


                //add usertoken
                if (_userToken != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_userToken}");
                }

                //request
                HttpResponseMessage result = null;
                switch (method)
                {
                    case AllowedHttpVerbs.Delete:
                        result = await client.DeleteAsync($"{url}");
                        break;

                    case AllowedHttpVerbs.Get:
                        result = await client.GetAsync($"{url}");
                        break;

                    case AllowedHttpVerbs.Post:
                        result = await HttpClientExtensions.PostAsJsonAsync(client, url, parameters);
                        break;

                    case AllowedHttpVerbs.Put:
                        result = await HttpClientExtensions.PutAsJsonAsync(client, url, parameters);
                        break;
                }

                using (result)
                {
                    string resultAsString = await result.Content.ReadAsStringAsync();

                    if (result.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject(resultAsString);
                    }
                    else
                    {
                        ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(resultAsString);

                        if (errorResponse != null)
                        {
                            throw new BetaSeriesException(errorResponse);
                        }

                        return errorResponse;
                    }
                }
            }
        }

        #endregion Private Methods
    }
}
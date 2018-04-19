using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using BetaSeries.Net.Exceptions;
using BetaSeries.Net.Models;

namespace BetaSeries.Net
{
    public static class RestHelper
    {
        private static string _apiBaseUri = "https://api.betaseries.com/";
        private static string _apiVersion = "3.0";
        private static string _developerKey = null;
        private static Dictionary<Type, string> _urlByType = new Dictionary<Type, string>();
        private static string _userToken = null;

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

        public static void RegisterDeveloperKey(string key)
        {
            _developerKey = key;
        }

        public static void RegisterUserToken(string token)
        {
            _userToken = token;
        }

        public static async Task<dynamic> Get<T>(dynamic parameters = null) where T : class
        {
            if (string.IsNullOrWhiteSpace(_developerKey))
            {
                throw new NoDeveloperKeyException();
            }

            string url = GetUrlOrThrow(typeof(T));

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiBaseUri);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Key", _developerKey);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Version", _apiVersion);

                //add usertoken
                if (_userToken != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_userToken}");
                }

                //add parameters
                url += DynamicToQueryString(parameters);

                //request
                using (HttpResponseMessage result = await client.GetAsync($"{url}"))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        string resultAsString = await result.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject(resultAsString);
                    }
                }
            }

            return null;
        }

        public static async Task<dynamic> Post<T>(dynamic parameters) where T : class
        {
            if (string.IsNullOrWhiteSpace(_developerKey))
            {
                throw new NoDeveloperKeyException();
            }

            string url = GetUrlOrThrow(typeof(T));

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiBaseUri);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Key", _developerKey);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Version", _apiVersion);

                //add usertoken
                if (_userToken != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_userToken}");
                }

                //request
                using (HttpResponseMessage result = await HttpClientExtensions.PostAsJsonAsync(client, url, parameters))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        string resultAsString = await result.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject(resultAsString);
                    }
                }
            }

            return null;
        }

        public static async Task<dynamic> Put<T>(Parameters parameters) where T : class
        {
            if (string.IsNullOrWhiteSpace(_developerKey))
            {
                throw new NoDeveloperKeyException();
            }

            string url = GetUrlOrThrow(typeof(T));

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiBaseUri);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Key", _developerKey);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Version", _apiVersion);

                //add usertoken
                if (_userToken != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_userToken}");
                }

                //request
                using (HttpResponseMessage result = await HttpClientExtensions.PostAsJsonAsync(client, url, parameters))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        string resultAsString = await result.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject(resultAsString);
                    }
                }
            }

            return null;
        }

        public static async Task<dynamic> Delete<T>(Parameters parameters) where T : class
        {
            if (string.IsNullOrWhiteSpace(_developerKey))
            {
                throw new NoDeveloperKeyException();
            }

            string url = GetUrlOrThrow(typeof(T));

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiBaseUri);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Key", _developerKey);
                client.DefaultRequestHeaders.Add("X-BetaSeries-Version", _apiVersion);

                //add usertoken
                if (_userToken != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_userToken}");
                }

                //add parameters
                url += (parameters as Parameters).ToString();

                //request
                using (HttpResponseMessage result = await client.DeleteAsync($"{url}"))
                {
                    if (result.IsSuccessStatusCode)
                    {
                        string resultAsString = await result.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject(resultAsString);
                    }
                }
            }

            return null;
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

    }
}

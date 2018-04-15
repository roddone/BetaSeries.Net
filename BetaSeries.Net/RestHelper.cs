using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using BetaSeries.Net.Exceptions;

namespace BetaSeries.Net
{
    public class RestHelper
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
                RestAttribute attr = t.GetCustomAttributes(restAttributeType, false)?.FirstOrDefault() as RestAttribute;

                if (attr != null)
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

        public void RegisterDeveloperKey(string key)
        {
            _developerKey = key;
        }

        public async Task<dynamic> Get<T>() where T : class
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

                if (_userToken != null)
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_userToken}");
                }

                using (HttpResponseMessage result = await client.GetAsync($"{url}"))//? id ={UserId}"))
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
    }
}

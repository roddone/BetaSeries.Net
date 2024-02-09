using BetaSeries.Net.Core;
using BetaSeries.Net.Exceptions;
using System.Threading.Tasks;

namespace BetaSeries.Net.Models
{
    public abstract class OAUTH
    {
        #region Public Classes
        private static string _device_code;
        private static string _developerKey;
        private static string _oautsecret;

        public static void RegisterDeveloperKey(string key)
        {
            _developerKey = key;
        }

        public static void RegisterOAuthSecret(string secret)
        {
            _oautsecret = secret;
        }

        [Rest]
        public class Access_token : RestMethod<Access_token>
        {
            public static async System.Threading.Tasks.Task<dynamic> PollForAuthorization()
            {
                while (true)
                {
                    try
                    {
                        dynamic result = await Post(new { client_id = _developerKey, client_secret = _oautsecret, code = _device_code });

                        RestHelper.RegisterUserToken(result.access_token.ToString());

                        return result;
                    }
                    catch (BetaSeriesException)
                    {
                        await Task.Delay(5000);
                    }
                }
            }
        }

        [Rest]
        public class Device : RestMethod<Device>
        {
            public static async Task<dynamic> Post()
            {
                dynamic res = await RestHelper.Post<Device>(new { });
                _device_code = res.device_code;
                return res;
            }
        }
        #endregion Public Classes
    }
}
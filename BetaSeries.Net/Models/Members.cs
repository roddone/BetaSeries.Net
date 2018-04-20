using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class MEMBERS
    {
        #region Public Classes

        [Rest]
        public class Access_token : RestMethod<Access_token> { }

        [Rest]
        public class Auth : RestMethod<Auth>
        {
            public static async System.Threading.Tasks.Task<dynamic> Connect(string login, string password)
            {
                dynamic result = await Post(new { login, password = RestHelper.HashPassword(password) });

                RestHelper.RegisterUserToken(result.token.ToString());

                return result;
            }
        }

        [Rest]
        public class Avatar : RestMethod<Avatar> { }

        [Rest]
        public class Badges : RestMethod<Badges> { }

        [Rest]
        public class Banner : RestMethod<Banner> { }

        [Rest]
        public class Destroy : RestMethod<Destroy> { }

        [Rest]
        public class Email : RestMethod<Email> { }

        [Rest]
        public class Facebook : RestMethod<Facebook> { }

        [Rest]
        public class Infos : RestMethod<Infos> { }

        [Rest]
        public class Is_Active : RestMethod<Is_Active> { }

        [Rest]
        public class LaMetric : RestMethod<LaMetric> { }

        [Rest]
        public class Locale : RestMethod<Locale> { }

        [Rest]
        public class Lost : RestMethod<Lost> { }

        [Rest]
        public class Notification : RestMethod<Notification> { }

        [Rest]
        public class Notifications : RestMethod<Notifications> { }

        [Rest]
        public class OAuth : RestMethod<OAuth> { }

        [Rest]
        public class Option : RestMethod<Option> { }

        [Rest]
        public class Options : RestMethod<Options> { }

        [Rest]
        public class Password : RestMethod<Password> { }

        [Rest]
        public class Search : RestMethod<Search> { }

        [Rest]
        public class Signup : RestMethod<Signup> { }

        [Rest]
        public class Sync : RestMethod<Sync> { }

        [Rest]
        public class UserName : RestMethod<UserName> { }

        #endregion Public Classes
    }
}
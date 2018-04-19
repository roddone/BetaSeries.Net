using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class MEMBERS
    {
        #region Public Classes

        [Rest]
        public class Access_token : IRest<Access_token> { }

        [Rest]
        public class Auth : IRest<Auth> { }

        [Rest]
        public class Avatar : IRest<Avatar> { }

        [Rest]
        public class Badges : IRest<Badges> { }

        [Rest]
        public class Banner : IRest<Banner> { }

        [Rest]
        public class Destroy : IRest<Destroy> { }

        [Rest]
        public class Email : IRest<Email> { }

        [Rest]
        public class Facebook : IRest<Facebook> { }

        [Rest]
        public class Infos : IRest<Infos> { }

        [Rest]
        public class Is_Active : IRest<Is_Active> { }

        [Rest]
        public class LaMetric : IRest<LaMetric> { }

        [Rest]
        public class Locale : IRest<Locale> { }

        [Rest]
        public class Lost : IRest<Lost> { }

        [Rest]
        public class Notification : IRest<Notification> { }

        [Rest]
        public class Notifications : IRest<Notifications> { }

        [Rest]
        public class OAuth : IRest<OAuth> { }

        [Rest]
        public class Option : IRest<Option> { }

        [Rest]
        public class Options : IRest<Options> { }

        [Rest]
        public class Password : IRest<Password> { }

        [Rest]
        public class Search : IRest<Search> { }

        [Rest]
        public class Signup : IRest<Signup> { }

        [Rest]
        public class Sync : IRest<Sync> { }

        [Rest]
        public class UserName : IRest<UserName> { }

        #endregion Public Classes
    }
}
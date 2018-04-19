using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class TIMELINE
    {
        #region Public Classes

        [Rest]
        public class Event : RestMethod<Event> { }

        [Rest]
        public class Feed : RestMethod<Feed> { }

        [Rest]
        public class Friends : RestMethod<Friends> { }

        [Rest]
        public class Home : RestMethod<Home> { }

        [Rest]
        public class Member : RestMethod<Member> { }

        [Rest]
        public class Show : RestMethod<Show> { }

        #endregion Public Classes
    }
}
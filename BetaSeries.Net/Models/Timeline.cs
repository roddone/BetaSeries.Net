using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class TIMELINE
    {
        #region Public Classes

        [Rest]
        public class Event : IRest<Event> { }

        [Rest]
        public class Feed : IRest<Feed> { }

        [Rest]
        public class Friends : IRest<Friends> { }

        [Rest]
        public class Home : IRest<Home> { }

        [Rest]
        public class Member : IRest<Member> { }

        [Rest]
        public class Show : IRest<Show> { }

        #endregion Public Classes
    }
}
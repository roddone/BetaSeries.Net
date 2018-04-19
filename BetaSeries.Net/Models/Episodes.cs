using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class EPISODES
    {
        #region Public Classes

        [Rest]
        public class Display : RestMethod<Display> { }

        [Rest]
        public class Downloaded : RestMethod<Downloaded> { }

        [Rest]
        public class Hidden : RestMethod<Hidden> { }

        [Rest]
        public class Latest : RestMethod<Latest> { }

        [Rest]
        public class List : RestMethod<List> { }

        [Rest]
        public class Next : RestMethod<Next> { }

        [Rest]
        public class Note : RestMethod<Note> { }

        [Rest]
        public class Scraper : RestMethod<Scraper> { }

        [Rest]
        public class Search : RestMethod<Search> { }

        [Rest]
        public class Watched : RestMethod<Watched> { }

        #endregion Public Classes
    }
}
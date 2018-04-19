using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class EPISODES
    {
        #region Public Classes

        [Rest]
        public class Display : IRest<Display> { }

        [Rest]
        public class Downloaded : IRest<Downloaded> { }

        [Rest]
        public class Hidden : IRest<Hidden> { }

        [Rest]
        public class Latest : IRest<Latest> { }

        [Rest]
        public class List : IRest<List> { }

        [Rest]
        public class Next : IRest<Next> { }

        [Rest]
        public class Note : IRest<Note> { }

        [Rest]
        public class Scraper : IRest<Scraper> { }

        [Rest]
        public class Search : IRest<Search> { }

        [Rest]
        public class Watched : IRest<Watched> { }

        #endregion Public Classes
    }
}
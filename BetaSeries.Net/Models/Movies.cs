using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class MOVIES
    {
        #region Public Classes

        [Rest]
        public class Characters : RestMethod<Characters> { }

        [Rest]
        public class Discover : RestMethod<Discover> { }

        [Rest]
        public class Favorite : RestMethod<Favorite> { }

        [Rest]
        public class Favorites : RestMethod<Favorites> { }

        [Rest]
        public class List : RestMethod<List> { }

        [Rest]
        public class Member : RestMethod<Member> { }

        [Rest]
        public class Movie : RestMethod<Movie> { }

        [Rest]
        public class Note : RestMethod<Note> { }

        [Rest]
        public class Random : RestMethod<Random> { }

        [Rest]
        public class Scraper : RestMethod<Scraper> { }

        [Rest]
        public class Search : RestMethod<Search> { }

        [Rest]
        public class Similars : RestMethod<Similars> { }

        [Rest]
        public class Upcoming : RestMethod<Upcoming> { }

        #endregion Public Classes
    }
}
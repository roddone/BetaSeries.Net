using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class SHOWS
    {
        #region Public Classes

        [Rest]
        public class Archive : RestMethod<Archive> { }

        [Rest]
        public class Characters : RestMethod<Characters> { }

        [Rest]
        public class Discover : RestMethod<Discover> { }

        [Rest]
        public class Display : RestMethod<Display> { }

        [Rest]
        public class Episodes : RestMethod<Episodes> { }

        [Rest]
        public class Favorite : RestMethod<Favorite> { }

        [Rest]
        public class Genres : RestMethod<Genres> { }

        [Rest]
        public class List : RestMethod<List> { }

        [Rest]
        public class Member : RestMethod<Member> { }

        [Rest]
        public class Note : RestMethod<Note> { }

        [Rest]
        public class Pictures : RestMethod<Pictures> { }

        [Rest]
        public class Posters : RestMethod<Posters> { }

        [Rest]
        public class Random : RestMethod<Random> { }

        [Rest]
        public class Recommendation : RestMethod<Recommendation> { }

        [Rest]
        public class Recommendations : RestMethod<Recommendations> { }

        [Rest]
        public class Search : RestMethod<Search> { }

        [Rest]
        public class Seasons : RestMethod<Seasons> { }

        [Rest]
        public class Show : RestMethod<Show> { }

        [Rest]
        public class Similars : RestMethod<Similars> { }

        [Rest]
        public class Tags : RestMethod<Tags> { }

        [Rest]
        public class Videos : RestMethod<Videos> { }

        #endregion Public Classes
    }
}
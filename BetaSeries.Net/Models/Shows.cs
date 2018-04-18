using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public abstract class SHOWS
    {
        [Rest]
        public class Archive : IRest<Archive> { }

        [Rest]
        public class Characters : IRest<Characters> { }

        [Rest]
        public class Discover : IRest<Discover> { }

        [Rest]
        public class Display : IRest<Display> { }

        [Rest]
        public class Episodes : IRest<Episodes> { }

        [Rest]
        public class Favorite : IRest<Favorite> { }

        [Rest]
        public class Genres : IRest<Genres> { }

        [Rest]
        public class List : IRest<List> { }

        [Rest]
        public class Member : IRest<Member> { }

        [Rest]
        public class Note : IRest<Note> { }

        [Rest]
        public class Pictures : IRest<Pictures> { }

        [Rest]
        public class Posters : IRest<Posters> { }

        [Rest]
        public class Random : IRest<Random> { }

        [Rest]
        public class Recommendation : IRest<Recommendation> { }

        [Rest]
        public class Recommendations : IRest<Recommendations> { }

        [Rest]
        public class Search : IRest<Search> { }

        [Rest]
        public class Show : IRest<Show> { }

        [Rest]
        public class Similars : IRest<Similars> { }

        [Rest]
        public class Tags : IRest<Tags> { }

        [Rest]
        public class Videos : IRest<Videos> { }
    }
}

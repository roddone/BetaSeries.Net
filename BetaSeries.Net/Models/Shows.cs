using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public class Shows
    {
        [Rest]
        public class Archive: DynamicObject { }

        [Rest]
        public class Characters: DynamicObject { }

        [Rest]
        public class Discover: DynamicObject { }

        [Rest]
        public class Display: DynamicObject { }

        [Rest]
        public class Episodes : DynamicObject { }

        [Rest]
        public class Favorite : DynamicObject { }

        [Rest]
        public class Genres : DynamicObject { }

        [Rest]
        public class List : DynamicObject { }

        [Rest]
        public class Member : DynamicObject { }

        [Rest]
        public class Note : DynamicObject { }

        [Rest]
        public class Pictures : DynamicObject { }

        [Rest]
        public class Posters : DynamicObject { }

        [Rest]
        public class Random : DynamicObject { }

        [Rest]
        public class Recommendation : DynamicObject { }

        [Rest]
        public class Recommendations : DynamicObject { }

        [Rest]
        public class Search : DynamicObject { }

        [Rest]
        public class Show : DynamicObject { }

        [Rest]
        public class Similars : DynamicObject { }

        [Rest]
        public class Tags : DynamicObject { }

        [Rest]
        public class Videos : DynamicObject { }
    }
}

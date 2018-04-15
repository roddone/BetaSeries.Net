using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public class Episodes
    {
        [Rest]
        public class Display: DynamicObject { }

        [Rest]
        public class Downloaded: DynamicObject { }

        [Rest]
        public class Hidden : DynamicObject { }

        [Rest]
        public class Latest : DynamicObject{ }

        [Rest]
        public class List: DynamicObject { }

        [Rest]
        public class Next: DynamicObject { }

        [Rest]
        public class Note : DynamicObject { }

        [Rest]
        public class Scraper : DynamicObject { }

        [Rest]
        public class Search : DynamicObject { }

        [Rest]
        public class Watched : DynamicObject { }
    }
}

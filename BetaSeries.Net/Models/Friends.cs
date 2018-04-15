using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public class Friends
    {
        [Rest]
        public class Block : DynamicObject { }

        [Rest]
        public class Find : DynamicObject{ }

        [Rest]
        public class Friend: DynamicObject { }

        [Rest]
        public class List : DynamicObject { }

        [Rest]
        public class Requests : DynamicObject { }
    }
}

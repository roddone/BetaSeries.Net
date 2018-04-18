using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public abstract class FRIENDS
    {
        [Rest]
        public class Block : IRest<Block> { }

        [Rest]
        public class Find : IRest<Find> { }

        [Rest]
        public class Friend : IRest<Friend> { }

        [Rest]
        public class List : IRest<List> { }

        [Rest]
        public class Requests : IRest<Requests> { }
    }
}

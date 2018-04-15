using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    [Rest(Url = "comments/comments")]
    public class Comments : DynamicObject
    {
        public class Comment : DynamicObject { }

        public class Replies : List<Comment> { }

        public class Subscription : DynamicObject { }
    }
}

using BetaSeries.Net.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public abstract class COMMENTS
    {
        [Rest]
        public class Comment:IRest<Comment> { }

        [Rest]
        public class Comments: IRest<Comments> { }

        [Rest]
        public class Replies: IRest<Replies> { }

        [Rest]
        public class Subscription: IRest<Subscription> { }
    }
}

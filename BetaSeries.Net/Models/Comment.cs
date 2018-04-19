using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class COMMENTS
    {
        #region Public Classes

        [Rest]
        public class Comment : RestMethod<Comment> { }

        [Rest]
        public class Comments : RestMethod<Comments> { }

        [Rest]
        public class Replies : RestMethod<Replies> { }

        [Rest]
        public class Subscription : RestMethod<Subscription> { }

        #endregion Public Classes
    }
}
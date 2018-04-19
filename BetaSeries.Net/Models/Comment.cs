using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class COMMENTS
    {
        #region Public Classes

        [Rest]
        public class Comment : IRest<Comment> { }

        [Rest]
        public class Comments : IRest<Comments> { }

        [Rest]
        public class Replies : IRest<Replies> { }

        [Rest]
        public class Subscription : IRest<Subscription> { }

        #endregion Public Classes
    }
}
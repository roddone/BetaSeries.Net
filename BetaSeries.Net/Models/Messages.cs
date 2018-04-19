using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class MESSAGES
    {
        #region Public Classes

        [Rest]
        public class Discussion : IRest<Discussion> { }

        [Rest]
        public class Inbox : IRest<Inbox> { }

        [Rest]
        public class Message : IRest<Message> { }

        [Rest]
        public class Read : IRest<Read> { }

        #endregion Public Classes
    }
}
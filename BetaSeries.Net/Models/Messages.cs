using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class MESSAGES
    {
        #region Public Classes

        [Rest]
        public class Discussion : RestMethod<Discussion> { }

        [Rest]
        public class Inbox : RestMethod<Inbox> { }

        [Rest]
        public class Message : RestMethod<Message> { }

        [Rest]
        public class Read : RestMethod<Read> { }

        #endregion Public Classes
    }
}
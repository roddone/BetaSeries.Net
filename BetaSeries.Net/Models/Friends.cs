using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class FRIENDS
    {
        #region Public Classes

        [Rest]
        public class Block : RestMethod<Block> { }

        [Rest]
        public class Find : RestMethod<Find> { }

        [Rest]
        public class Friend : RestMethod<Friend> { }

        [Rest]
        public class List : RestMethod<List> { }

        [Rest]
        public class Requests : RestMethod<Requests> { }

        #endregion Public Classes
    }
}
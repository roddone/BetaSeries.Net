using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class FRIENDS
    {
        #region Public Classes

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

        #endregion Public Classes
    }
}
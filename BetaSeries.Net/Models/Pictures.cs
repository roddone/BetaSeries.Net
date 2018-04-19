using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class PICTURES
    {
        #region Public Classes

        [Rest]
        public class Badges : RestMethod<Badges> { }

        [Rest]
        public class Characters : RestMethod<Characters> { }

        [Rest]
        public class Episodes : RestMethod<Episodes> { }

        [Rest]
        public class Members : RestMethod<Members> { }

        [Rest]
        public class Movies : RestMethod<Movies> { }

        [Rest]
        public class Seasons : RestMethod<Seasons> { }

        [Rest]
        public class Shows : RestMethod<Shows> { }

        #endregion Public Classes
    }
}
using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class PUSH
    {
        #region Public Classes

        [Rest]
        public class Push : RestMethod<Push> { }

        [Rest]
        public class Subscription : RestMethod<Subscription> { }

        #endregion Public Classes
    }
}
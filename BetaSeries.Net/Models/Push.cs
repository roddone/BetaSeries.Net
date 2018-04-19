using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class PUSH
    {
        #region Public Classes

        [Rest]
        public class Push : IRest<Push> { }

        [Rest]
        public class Subscription : IRest<Subscription> { }

        #endregion Public Classes
    }
}
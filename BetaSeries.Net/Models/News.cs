using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class NEWS
    {
        #region Public Classes

        [Rest]
        public class Last : IRest<Last> { }

        #endregion Public Classes
    }
}
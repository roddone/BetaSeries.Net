using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class POLLS
    {
        #region Public Classes

        [Rest]
        public class Answer : IRest<Answer> { }

        [Rest]
        public class Last : IRest<Last> { }

        #endregion Public Classes
    }
}
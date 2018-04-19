using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class POLLS
    {
        #region Public Classes

        [Rest]
        public class Answer : RestMethod<Answer> { }

        [Rest]
        public class Last : RestMethod<Last> { }

        #endregion Public Classes
    }
}
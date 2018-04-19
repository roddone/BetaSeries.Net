using System;

namespace BetaSeries.Net.Exceptions
{
    public class NoDeveloperKeyException : Exception
    {
        #region Public Constructors

        public NoDeveloperKeyException() : base("A developer key is needed to use BetaSeries API")
        {
        }

        #endregion Public Constructors
    }
}
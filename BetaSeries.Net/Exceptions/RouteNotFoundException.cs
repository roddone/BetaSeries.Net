using System;

namespace BetaSeries.Net.Exceptions
{
    public class RouteNotFoundException : Exception
    {
        #region Public Constructors

        public RouteNotFoundException(Type t) : base($"No route found for type {t}")
        {
        }

        #endregion Public Constructors
    }
}
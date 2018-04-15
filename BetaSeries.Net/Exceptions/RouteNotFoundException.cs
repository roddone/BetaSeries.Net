using System;
using System.Collections.Generic;
using System.Text;

namespace BetaSeries.Net.Exceptions
{
    public class RouteNotFoundException : Exception
    {
        public RouteNotFoundException(Type t) : base($"No route found for type {t}")
        {
        }
    }
}

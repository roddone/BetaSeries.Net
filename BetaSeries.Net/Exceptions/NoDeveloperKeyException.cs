using System;
using System.Collections.Generic;
using System.Text;

namespace BetaSeries.Net.Exceptions
{
    public class NoDeveloperKeyException : Exception
    {
        public NoDeveloperKeyException() : base("A developer key is needed to use BetaSeries API") { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BetaSeries.Net.Core
{
    internal class RestAttribute : Attribute
    {
        public string Url { get; set; }

    }
}

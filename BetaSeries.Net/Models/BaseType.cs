using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BetaSeries.Net.Models
{
    public abstract class BaseType<T> : DynamicObject where T : class
    {
        public List<Error> Errors { get; set; }
    }
}

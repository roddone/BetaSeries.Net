using System.Collections.Generic;
using System.Dynamic;

namespace BetaSeries.Net.Models
{
    public abstract class BaseType<T> : DynamicObject where T : class
    {
        #region Public Properties

        public List<Error> Errors { get; set; }

        #endregion Public Properties
    }
}
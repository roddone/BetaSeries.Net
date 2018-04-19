using System;

namespace BetaSeries.Net.Core
{
    internal class RestAttribute : Attribute
    {
        #region Public Properties

        public string Url { get; set; }

        #endregion Public Properties
    }
}
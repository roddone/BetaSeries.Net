using BetaSeries.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BetaSeries.Net.Exceptions
{
    public class BetaSeriesException : Exception
    {
        #region Public Properties

        public List<Error> BetaSeriesErrors { get; set; } = new List<Error>();

        #endregion Public Properties

        #region Public Constructors

        public BetaSeriesException(Error error) : base($"BetaSeries Error : {error?.Text} (Code : {error?.Code})")
        {
            BetaSeriesErrors.Add(error);
        }

        public BetaSeriesException(List<Error> errors) : base($"BetaSeries Error : {errors?.ElementAt(0)?.Text} (Code : {errors?.ElementAt(0)?.Code})")
        {
            BetaSeriesErrors.AddRange(errors);
        }

        public BetaSeriesException(ErrorResponse error) : base($"BetaSeries Error : {error.Errors?.ElementAt(0)?.Text} (Code : {error.Errors?.ElementAt(0)?.Code})")
        {
            BetaSeriesErrors.AddRange(error.Errors);
        }

        #endregion Public Constructors
    }
}
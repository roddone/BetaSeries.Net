using System.Collections.Generic;

namespace BetaSeries.Net.Models
{
    public class Error
    {
        #region Public Properties

        public ErrorCode Code { get; set; }

        public string Text { get; set; }

        #endregion Public Properties
    }

    public class ErrorResponse
    {
        #region Public Properties

        public List<Error> Errors { get; set; }

        #endregion Public Properties
    }
}
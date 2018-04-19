using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class REPORTS
    {
        #region Public Classes

        [Rest]
        public class Report : RestMethod<Report> { }

        [Rest]
        public class Update : RestMethod<Update> { }

        #endregion Public Classes
    }
}
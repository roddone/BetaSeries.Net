using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class REPORTS
    {
        #region Public Classes

        [Rest]
        public class Report : IRest<Report> { }

        [Rest]
        public class Update : IRest<Update> { }

        #endregion Public Classes
    }
}
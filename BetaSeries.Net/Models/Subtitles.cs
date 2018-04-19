using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class SUBTITLES
    {
        #region Public Classes

        [Rest]
        public class Episode : RestMethod<Episode> { }

        [Rest]
        public class Last : RestMethod<Last> { }

        [Rest]
        public class Report : RestMethod<Report> { }

        [Rest]
        public class Season : RestMethod<Season> { }

        [Rest]
        public class Show : RestMethod<Show> { }

        #endregion Public Classes
    }
}
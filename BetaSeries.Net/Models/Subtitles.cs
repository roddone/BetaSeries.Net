using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class SUBTITLES
    {
        #region Public Classes

        [Rest]
        public class Episode : IRest<Episode> { }

        [Rest]
        public class Last : IRest<Last> { }

        [Rest]
        public class Report : IRest<Report> { }

        [Rest]
        public class Season : IRest<Season> { }

        [Rest]
        public class Show : IRest<Show> { }

        #endregion Public Classes
    }
}
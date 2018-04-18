using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class SUBTITLES
    {


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
    }
}

using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class PLANNING
    {
        #region Public Classes

        [Rest]
        public class Calendar : IRest<Calendar> { }

        [Rest]
        public class General : IRest<General> { }

        [Rest]
        public class Incoming : IRest<Incoming> { }

        [Rest]
        public class Member : IRest<Member> { }

        [Rest]
        public class Timeline : IRest<Timeline> { }

        #endregion Public Classes
    }
}
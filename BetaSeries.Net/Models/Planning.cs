using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class PLANNING
    {
        #region Public Classes

        [Rest]
        public class Calendar : RestMethod<Calendar> { }

        [Rest]
        public class General : RestMethod<General> { }

        [Rest]
        public class Incoming : RestMethod<Incoming> { }

        [Rest]
        public class Member : RestMethod<Member> { }

        [Rest]
        public class Timeline : RestMethod<Timeline> { }

        #endregion Public Classes
    }
}
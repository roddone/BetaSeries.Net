using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class PLANNING
	{


		[Rest]
		public class Calendar : IRest<Calendar> {}


		[Rest]
		public class General : IRest<General> {}


		[Rest]
		public class Incoming : IRest<Incoming> {}


		[Rest]
		public class Member : IRest<Member> {}


		[Rest]
		public class Timeline : IRest<Timeline> {}
	}
}

using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Planning
	{


		[Rest]
		public class Calendar : DynamicObject {}


		[Rest]
		public class General : DynamicObject {}


		[Rest]
		public class Incoming : DynamicObject {}


		[Rest]
		public class Member : DynamicObject {}


		[Rest]
		public class Timeline : DynamicObject {}
	}
}

using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Timeline
	{


		[Rest]
		public class Event : DynamicObject {}


		[Rest]
		public class Feed : DynamicObject {}


		[Rest]
		public class Friends : DynamicObject {}


		[Rest]
		public class Home : DynamicObject {}


		[Rest]
		public class Member : DynamicObject {}


		[Rest]
		public class Show : DynamicObject {}
	}
}

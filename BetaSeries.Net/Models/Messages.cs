using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Messages
	{


		[Rest]
		public class Discussion : DynamicObject {}


		[Rest]
		public class Inbox : DynamicObject {}


		[Rest]
		public class Message : DynamicObject {}

		[Rest]
		public class Read : DynamicObject {}
	}
}

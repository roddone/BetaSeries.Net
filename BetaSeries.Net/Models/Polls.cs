using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Polls
	{


		[Rest]
		public class Answer : DynamicObject {}


		[Rest]
		public class Last : DynamicObject {}
	}
}

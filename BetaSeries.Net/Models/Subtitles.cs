using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Subtitles
	{


		[Rest]
		public class Episode : DynamicObject {}


		[Rest]
		public class Last : DynamicObject {}


		[Rest]
		public class Report : DynamicObject {}


		[Rest]
		public class Season : DynamicObject {}


		[Rest]
		public class Show : DynamicObject {}
	}
}

using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Pictures
	{


		[Rest]
		public class Badges : DynamicObject {}


		[Rest]
		public class Characters : DynamicObject {}


		[Rest]
		public class Episodes : DynamicObject {}


		[Rest]
		public class Members : DynamicObject {}


		[Rest]
		public class Movies : DynamicObject {}


		[Rest]
		public class Seasons : DynamicObject {}


		[Rest]
		public class Shows : DynamicObject {}
	}
}

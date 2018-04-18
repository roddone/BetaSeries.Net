using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class PICTURES
	{


		[Rest]
		public class Badges : IRest<Badges> {}


		[Rest]
		public class Characters : IRest<Characters> {}


		[Rest]
		public class Episodes : IRest<Episodes> {}


		[Rest]
		public class Members : IRest<Members> {}


		[Rest]
		public class Movies : IRest<Movies> {}


		[Rest]
		public class Seasons : IRest<Seasons> {}


		[Rest]
		public class Shows : IRest<Shows> {}
	}
}

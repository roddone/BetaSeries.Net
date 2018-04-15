using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Movies
	{


		[Rest]
		public class Characters : DynamicObject {}


		[Rest]
		public class Discover : DynamicObject {}


		[Rest]
		public class Favorite : DynamicObject {}


		[Rest]
		public class Favorites : DynamicObject {}


		[Rest]
		public class List : DynamicObject {}


		[Rest]
		public class Member : DynamicObject {}


		[Rest]
		public class Movie : DynamicObject {}


		[Rest]
		public class Note : DynamicObject {}


		[Rest]
		public class Random : DynamicObject {}


		[Rest]
		public class Scraper : DynamicObject {}


		[Rest]
		public class Search : DynamicObject {}


		[Rest]
		public class Similars : DynamicObject {}


		[Rest]
		public class Upcoming : DynamicObject {}
	}
}

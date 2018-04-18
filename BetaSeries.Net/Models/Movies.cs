using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class MOVIES
	{


		[Rest]
		public class Characters : IRest<Characters> {}


		[Rest]
		public class Discover : IRest<Discover> {}


		[Rest]
		public class Favorite : IRest<Favorite> {}


		[Rest]
		public class Favorites : IRest<Favorites> {}


		[Rest]
		public class List : IRest<List> {}


		[Rest]
		public class Member : IRest<Member> {}


		[Rest]
		public class Movie : IRest<Movie> {}


		[Rest]
		public class Note : IRest<Note> {}


		[Rest]
		public class Random : IRest<Random> {}


		[Rest]
		public class Scraper : IRest<Scraper> {}


		[Rest]
		public class Search : IRest<Search> {}


		[Rest]
		public class Similars : IRest<Similars> {}


		[Rest]
		public class Upcoming : IRest<Upcoming> {}
	}
}

using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public abstract class TIMELINE
	{


		[Rest]
		public class Event : IRest<Event> {}


		[Rest]
		public class Feed : IRest<Feed>{}


		[Rest]
		public class Friends : IRest<Friends> {}


		[Rest]
		public class Home : IRest<Home>{}


		[Rest]
		public class Member : IRest<Member>{}


		[Rest]
		public class Show : IRest<Show>{}
	}
}

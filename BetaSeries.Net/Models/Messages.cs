using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class MESSAGES
	{


		[Rest]
		public class Discussion : IRest<Discussion> {}


		[Rest]
		public class Inbox : IRest<Inbox> {}


		[Rest]
		public class Message : IRest<Message> {}

		[Rest]
		public class Read : IRest<Read> {}
	}
}

using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class POLLS
	{


		[Rest]
		public class Answer : IRest<Answer> {}


		[Rest]
		public class Last : IRest<Last> {}
	}
}

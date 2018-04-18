using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class NEWS
	{


		[Rest]
		public class Last : IRest<Last> {}
	}
}

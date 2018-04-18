using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    [Rest(Url = "push/push")]
    public abstract class PUSH
	{

		[Rest]
		public class Subscription : IRest<Subscription> {}
	}
}

using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    [Rest(Url = "push/push")]
	public class Push
	{

		[Rest]
		public class Subscription : DynamicObject {}
	}
}

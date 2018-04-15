using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Oauth
	{


		[Rest]
		public class Access_token : DynamicObject {}
	}
}

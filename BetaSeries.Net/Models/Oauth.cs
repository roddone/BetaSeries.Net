using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class OAUTH
	{


		[Rest]
		public class Access_token : IRest<Access_token> {}
	}
}

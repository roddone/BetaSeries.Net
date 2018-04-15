using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
	public class Reports
	{


		[Rest]
		public class Report : DynamicObject {}


		[Rest]
		public class Update : DynamicObject {}
	}
}

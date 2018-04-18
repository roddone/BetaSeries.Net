using BetaSeries.Net.Core;
using System.Dynamic;


namespace BetaSeries.Net.Models
{
    public abstract class REPORTS
	{


		[Rest]
		public class Report : IRest<Report> {}


		[Rest]
		public class Update : IRest<Update> {}
	}
}

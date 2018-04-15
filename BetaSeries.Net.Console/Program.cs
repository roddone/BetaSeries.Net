using BetaSeries.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaSeries.Net.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RestHelper helper = new RestHelper();
            helper.RegisterDeveloperKey("");
            var res = helper.Get<Shows.Discover>().Result;


        }
    }
}

using BetaSeries.Net.Exceptions;
using BetaSeries.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BetaSeries.Net.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RestHelper.RegisterDeveloperKey("");

                dynamic auth = null;
                try
                {
                    //fake password to test exceptions
                    auth = MEMBERS.Auth.Post(new { login = "Dev095", password = RestHelper.HashPassword("developers") }).Result;
                }
                catch (Exception ex) when (ex.InnerException is BetaSeriesException)
                {
                    MEMBERS.Auth.Connect("Dev095", "developer").Wait();
                    // same as : auth = MEMBERS.Auth.Post(new { login = "Dev095", password = RestHelper.HashPassword("developer") }).Result;
                }
                
                var planning = PLANNING.Member.Get(new { id = "737887"/*auth.user.id.ToString()*/ }).Result;

                var res = SHOWS.Discover.Get().Result;
                res = SUBTITLES.Last.Get(new { number = 1, language = "vf" }).Result;
            }
            catch (Exception ex)
            {

            }

            System.Console.WriteLine("Press any key to continue ...");
            System.Console.ReadLine();
        }
    }
}

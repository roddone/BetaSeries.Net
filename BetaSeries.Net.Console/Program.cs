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
                    auth = MEMBERS.Auth.Post(new { login = "Dev095", password = CalculateMD5Hash("developers") }).Result;
                }
                catch (Exception ex) when (ex.InnerException is BetaSeriesException)
                {
                    auth = MEMBERS.Auth.Post(new { login = "Dev095", password = CalculateMD5Hash("developer") }).Result;
                }

                RestHelper.RegisterUserToken(auth.token.ToString());

                var planning = PLANNING.Member.Get(new { id = auth.user.id.ToString() }).Result;

                var res = SHOWS.Discover.Get().Result;
                res = SUBTITLES.Last.Get(new { number = 1, language = "vf" }).Result;
            }
            catch(Exception ex)
            {

            }

            System.Console.WriteLine("Press any key to continue ...");
            System.Console.ReadLine();
        }

        private static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            using (MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}

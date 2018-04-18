using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace BetaSeries.Net.Models
{

    public abstract class IRest<T> : DynamicObject where T : class
    {
        public static async Task<dynamic> Get(dynamic parameters = null)
        {
            return await RestHelper.Get<T>(parameters);
        }

        public static async Task<dynamic> Post(dynamic parameters)
        {
            return await RestHelper.Post<T>(parameters);
        }

        public static async Task<dynamic> Put(dynamic parameters)
        {
            return await RestHelper.Put<T>(parameters);
        }

        public static async Task<dynamic> Delete(dynamic parameters = null)
        {
            return await RestHelper.Delete<T>(parameters);
        }
    }
}

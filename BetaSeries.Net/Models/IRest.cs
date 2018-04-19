using System.Dynamic;
using System.Threading.Tasks;

namespace BetaSeries.Net.Models
{
    public abstract class RestMethod<T> : DynamicObject where T : class
    {
        #region Public Methods

        public static async Task<dynamic> Delete(dynamic parameters = null)
        {
            return await RestHelper.Delete<T>(parameters);
        }

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

        #endregion Public Methods
    }
}
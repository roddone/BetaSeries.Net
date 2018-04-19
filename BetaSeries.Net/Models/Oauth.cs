using BetaSeries.Net.Core;

namespace BetaSeries.Net.Models
{
    public abstract class OAUTH
    {
        #region Public Classes

        [Rest]
        public class Access_token : IRest<Access_token> { }

        #endregion Public Classes
    }
}
using System.Threading.Tasks;
using Illallangi.TheTvDb.Settings;
using Refit;

namespace Illallangi.TheTvDb.Tokens
{

    /// <summary>
    /// Obtaining and refreshing your JWT token
    /// </summary>
    public interface ITokenClient
    {

        /// <summary>
        /// Returns a session token to be included in the rest of the requests. Note that API key authentication is required for all subsequent requests and user
        /// auth is required for routes in the User section
        /// </summary>
        [Post(@"/login")]
        Task<IToken> RetrieveTokenByAuth([Body]ISetting loginParameters);
    }

}

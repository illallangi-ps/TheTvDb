using System.Threading.Tasks;

using Refit;

namespace Illallangi.TheTvDb.Series
{
    /// <summary>
    /// Information about a specific series
    /// </summary>
    [Headers(@"Authorization: Bearer")]
    public interface ISerieClient
    {
        /// <summary>
        /// Returns a series records that contains all information known about a particular series id.
        /// </summary>
        [Get(@"/series/{id}")]
        Task<SerieData> RetrieveSerieById(int id);

        /// <summary>
        /// Allows the user to search for a series based on the following parameters.
        /// </summary>
        [Get(@"/search/series")]
        Task<SerieSearchResults> SearchSerie(string name);
    }
}

using System.Threading.Tasks;

using Refit;

namespace Illallangi.TheTvDb.Languages
{
    /// <summary>
    /// Available languages and information.
    /// </summary>
    [Headers(@"Authorization: Bearer")]
    public interface ILanguageClient
    {
        /// <summary>
        /// All available languages. These language abbreviations can be used in the Accept-Language header for routes that return translation records.
        /// </summary>
        [Get(@"/languages")]
        Task<LanguageData> RetrieveLanguages();

        /// <summary>
        /// Information about a particular language, given the language ID.
        /// </summary>
        [Get(@"/languages/{id}")]
        Task<LanguageData> RetrieveLanguageById(int id);
    }
}

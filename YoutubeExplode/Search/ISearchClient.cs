using System.Collections.Generic;
using YoutubeExplode.Videos;

namespace YoutubeExplode.Search
{
    /// <summary>
    /// YouTube search queries.
    /// </summary>
    public interface ISearchClient
    {
        /// <summary>
        /// Enumerates videos returned by the specified search query.
        /// </summary>
        /// <param name="searchQuery">The term to look for.</param>
        /// <param name="startPage">Sets how many page should be skipped from the beginning of the search.</param>
        /// <param name="pageCount">Limits how many page should be requested to complete the search.</param>
        IAsyncEnumerable<Video> GetVideosAsync(string searchQuery, int startPage, int pageCount);

        /// <summary>
        /// Enumerates videos returned by the specified search query.
        /// </summary>
        // This needs to be an overload to maintain backwards compatibility
        IAsyncEnumerable<Video> GetVideosAsync(string searchQuery);
    }
}

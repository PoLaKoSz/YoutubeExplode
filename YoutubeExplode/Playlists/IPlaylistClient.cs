using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace YoutubeExplode.Playlists
{
    /// <summary>
    /// Queries related to YouTube playlists.
    /// </summary>
    public interface IPlaylistClient
    {
        /// <summary>
        /// Gets the metadata associated with the specified playlist.
        /// </summary>
        Task<Playlist> GetAsync(PlaylistId id);

        /// <summary>
        /// Enumerates videos included in the specified playlist.
        /// </summary>
        IAsyncEnumerable<Video> GetVideosAsync(PlaylistId id);
    }
}

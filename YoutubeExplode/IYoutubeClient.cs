using YoutubeExplode.Channels;
using YoutubeExplode.Playlists;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;

namespace YoutubeExplode
{
    /// <summary>
    /// Entry point for <see cref="YoutubeExplode"/>.
    /// </summary>
    public interface IYoutubeClient
    {
        /// <summary>
        /// Queries related to YouTube videos.
        /// </summary>
        VideoClient Videos { get; }

        /// <summary>
        /// Queries related to YouTube playlists.
        /// </summary>
        PlaylistClient Playlists { get; }

        /// <summary>
        /// Queries related to YouTube channels.
        /// </summary>
        ChannelClient Channels { get; }

        /// <summary>
        /// YouTube search queries.
        /// </summary>
        SearchClient Search { get; }
    }
}

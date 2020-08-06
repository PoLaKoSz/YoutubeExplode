using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace YoutubeExplode.Channels
{
    /// <summary>
    /// Queries related to YouTube channels.
    /// </summary>
    public interface IChannelClient
    {
        /// <summary>
        /// Gets the metadata associated with the specified channel.
        /// </summary>
        Task<Channel> GetAsync(ChannelId id);

        /// <summary>
        /// Gets the metadata associated with the channel of the specified user.
        /// </summary>
        Task<Channel> GetByUserAsync(UserName userName);

        /// <summary>
        /// Gets the metadata associated with the channel that uploaded the specified video.
        /// </summary>
        Task<Channel> GetByVideoAsync(VideoId videoId);

        /// <summary>
        /// Enumerates videos uploaded by the specified channel.
        /// </summary>
        IAsyncEnumerable<Video> GetUploadsAsync(ChannelId id);
    }
}

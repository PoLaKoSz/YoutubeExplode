using System.Threading.Tasks;
using YoutubeExplode.Videos.ClosedCaptions;
using YoutubeExplode.Videos.Streams;

namespace YoutubeExplode.Videos
{
    /// <summary>
    /// Queries related to YouTube videos.
    /// </summary>
    public interface IVideoClient
    {
        /// <summary>
        /// Queries related to media streams of YouTube videos.
        /// </summary>
        StreamsClient Streams { get; }

        /// <summary>
        /// Queries related to closed captions of YouTube videos.
        /// </summary>
        ClosedCaptionClient ClosedCaptions { get; }

        /// <summary>
        /// Gets the metadata associated with the specified video.
        /// </summary>
        Task<Video> GetAsync(VideoId id);
    }
}

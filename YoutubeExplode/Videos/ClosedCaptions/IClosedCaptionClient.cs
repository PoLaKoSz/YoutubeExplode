using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace YoutubeExplode.Videos.ClosedCaptions
{
    /// <summary>
    /// Queries related to closed captions of YouTube videos.
    /// </summary>
    public interface IClosedCaptionClient
    {
        /// <summary>
        /// Gets the manifest that contains information about available closed caption tracks in the specified video.
        /// </summary>
        Task<ClosedCaptionManifest> GetManifestAsync(VideoId videoId);

        /// <summary>
        /// Gets the actual closed caption track which is identified by the specified metadata.
        /// </summary>
        Task<ClosedCaptionTrack> GetAsync(ClosedCaptionTrackInfo trackInfo);

        /// <summary>
        /// Writes the actual closed caption track which is identified by the specified metadata to the specified writer.
        /// Closed captions are written in the SRT file format.
        /// </summary>
        Task WriteToAsync(ClosedCaptionTrackInfo trackInfo, TextWriter writer,
            IProgress<double>? progress = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Downloads the actual closed caption track which is identified by the specified metadata to the specified file.
        /// Closed captions are written in the SRT file format.
        /// </summary>
        Task DownloadAsync(ClosedCaptionTrackInfo trackInfo, string filePath,
            IProgress<double>? progress = null, CancellationToken cancellationToken = default);
    }
}

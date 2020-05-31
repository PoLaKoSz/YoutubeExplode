using System;
using System.Collections.Generic;
using YoutubeExplode.Channels;
using YoutubeExplode.Common;

namespace YoutubeExplode.Videos
{
    /// <summary>
    /// YouTube video metadata.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// Video ID.
        /// </summary>
        public VideoId Id { get; }

        /// <summary>
        /// Video URL.
        /// </summary>
        public string Url => $"https://www.youtube.com/watch?v={Id}";

        /// <summary>
        /// Video title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Video author.
        /// </summary>
        [System.Obsolete("This property will be removed in the next major release (6.0)! Use Uploader.Title instead!", error: false)]
        public string Author => Uploader.Title;

        /// <summary>
        /// Video uploader.
        /// </summary>
        public Channel Uploader { get; }

        /// <summary>
        /// Video upload date.
        /// </summary>
        public DateTimeOffset UploadDate { get; }

        /// <summary>
        /// Video description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Duration of the video.
        /// </summary>
        public TimeSpan Duration { get; }

        /// <summary>
        /// Available thumbnails for this video.
        /// </summary>
        public ThumbnailSet Thumbnails { get; }

        /// <summary>
        /// Search keywords used for this video.
        /// </summary>
        public IReadOnlyList<string> Keywords { get; }

        /// <summary>
        /// Engagement statistics for this video.
        /// </summary>
        public Engagement Engagement { get; }

        /// <summary>
        /// Initializes an instance of <see cref="Video"/>.
        /// </summary>
        public Video(
            VideoId id,
            string title,
            Channel uploader,
            DateTimeOffset uploadDate,
            string description,
            TimeSpan duration,
            ThumbnailSet thumbnails,
            IReadOnlyList<string> keywords,
            Engagement engagement)
        {
            Id = id;
            Title = title;
            Uploader = uploader;
            UploadDate = uploadDate;
            Description = description;
            Duration = duration;
            Thumbnails = thumbnails;
            Keywords = keywords;
            Engagement = engagement;
        }


        /// <inheritdoc />
        public override string ToString() => $"Video ({Title})";
    }
}
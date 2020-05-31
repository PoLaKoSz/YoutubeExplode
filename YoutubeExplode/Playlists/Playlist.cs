using YoutubeExplode.Channels;
using YoutubeExplode.Common;

namespace YoutubeExplode.Playlists
{
    /// <summary>
    /// YouTube playlist metadata.
    /// </summary>
    public class Playlist
    {
        /// <summary>
        /// Playlist ID.
        /// </summary>
        public PlaylistId Id { get; }

        /// <summary>
        /// Playlist URL.
        /// </summary>
        public string Url => $"https://www.youtube.com/playlist?list={Id}";

        /// <summary>
        /// Playlist title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Can be null if it's a system playlist (e.g. Video Mix, Topics, etc.).
        /// </summary>
        [System.Obsolete("This property will be removed in the next major release (6.0)! Use Uploader.Title instead!", error: false)]
        public string? Author => Uploader?.Title;

        /// <summary>
        /// Playlist uploader.
        /// Can be null if it's a system playlist (e.g. Video Mix, Topics, etc.).
        /// </summary>
        public Channel? Uploader { get; }

        /// <summary>
        /// Playlist description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Engagement statistics.
        /// </summary>
        public Engagement Engagement { get; }

        /// <summary>
        /// Initializes an instance of <see cref="Playlist"/>.
        /// </summary>
        public Playlist(PlaylistId id, string title, Channel? uploader, string description, Engagement engagement)
        {
            Id = id;
            Title = title;
            Uploader = uploader;
            Description = description;
            Engagement = engagement;
        }

        /// <inheritdoc />
        public override string ToString() => $"Playlist ({Title})";
    }
}
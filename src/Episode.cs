using System;

namespace PodFeedr
{
    public class Episode
    {
        /// <summary>
        /// The podcast title
        /// </summary>
        /// <returns></returns>
        public string Title { get; set; }

        /// <summary>
        /// Podcast Author(s)
        /// </summary>
        /// <returns></returns>
        public string Author { get; set; }

        /// <summary>
        /// Podcast summary
        /// </summary>
        /// <returns></returns>
        public string Summary { get; set; }

        /// <summary>
        /// Podcast unique GUID
        /// </summary>
        /// <returns></returns>
        public string Guid { get; set; }

        /// <summary>
        /// Podcast published date
        /// </summary>
        /// <returns></returns>
        public DateTime PubDate { get; set; }

        /// <summary>
        /// Podcast duration
        /// </summary>
        /// <returns></returns>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Podcast keywords, space separated
        /// </summary>
        /// <returns></returns>
        public string Keywords { get; set; }
    }
}

using System;
using System.IO;
using System.Xml;

namespace PodFeedr
{
    public class PodFeedr
    {
        private readonly Podcast podcast;

        public PodFeedr(Podcast podcast)
        {
            if(podcast == null)
            {
                throw new ArgumentNullException(nameof(podcast));
            }

            this.podcast = podcast;
        }

        /// <summary>
        /// Write XML stream
        /// </summary>
        /// <param name="stream"></param>
        public void WriteStream(Stream stream)
        {

        }
    }
}
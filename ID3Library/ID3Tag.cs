using System;

namespace ID3Library
{
    public class ID3Tag
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Year { get; set; }
        public string Comment { get; set; }
        public string Genre { get; set; }
        public string Filename { get; set; }

        public ID3Tag(string filename = "./pirates of the carib.mp3")
        {
            Filename = filename;
        }
    }
}

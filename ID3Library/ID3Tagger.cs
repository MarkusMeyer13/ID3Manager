using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3Library
{
    public class ID3Tagger
    {
        public delegate void NotifierDelegate(string message);

        public ID3Tag Tag { get; set; }

        private string _filename;
        public ID3Tagger(string filename = "./pirates of the carib.mp3")
        {
            _filename = filename;
        }

        public void Read(NotifierDelegate notifierDelegate)
        {
            FileStream stream = File.OpenRead(_filename);
            BinaryReader binaryReader = new BinaryReader(stream);

            long id3Length = 128;
            long fileLength = stream.Length;

            stream.Seek(id3Length * (-1), SeekOrigin.End);

            var tag = Encoding.UTF8.GetString(binaryReader.ReadBytes(3));
            Console.WriteLine(tag);

            this.Tag = new ID3Tag(_filename);

            this.Tag.Title = Encoding.UTF8.GetString(binaryReader.ReadBytes(30));

            notifierDelegate($"{nameof(this.Tag.Title)}: {this.Tag.Title}");

            this.Tag.Artist = Encoding.UTF8.GetString(binaryReader.ReadBytes(30));
            notifierDelegate($"{nameof(this.Tag.Artist)}: {this.Tag.Artist}");

            this.Tag.Album = Encoding.UTF8.GetString(binaryReader.ReadBytes(30));
            notifierDelegate($"{nameof(this.Tag.Album)}: {this.Tag.Album}");

            this.Tag.Year = Encoding.UTF8.GetString(binaryReader.ReadBytes(4));
            notifierDelegate($"{nameof(this.Tag.Year)}: {this.Tag.Year}");

            this.Tag.Comment = Encoding.UTF8.GetString(binaryReader.ReadBytes(30));
            notifierDelegate($"{nameof(this.Tag.Comment)}: {this.Tag.Comment}");

            this.Tag.Genre = Encoding.UTF8.GetString(binaryReader.ReadBytes(1));
            notifierDelegate($"{nameof(this.Tag.Genre)}: {this.Tag.Genre}");
        }
    }


}

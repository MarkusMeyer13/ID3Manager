using ID3Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3Cmd
{
    internal class ID3Reader
    {

        internal void Read()
        {
            ID3Tagger.NotifierDelegate handler = SendOut;

            ID3Tagger id3Tagger = new ID3Tagger();
            id3Tagger.Read(handler);

            #region hide
            //List<ID3Tag> tags = new List<ID3Tag>();
            //tags.Add(id3Tagger.Tag);
            //tags.Add(id3Tagger.Tag);

            //Func<ID3Tag, string> titleProjection = delegate (ID3Tag p) { return p.Title; };
            //Console.WriteLine("titleProjection: " + tags.Select(titleProjection).ToArray()[1]);


            //Func<ID3Tag, string> artistProjection = p => p.Artist;
            //Console.WriteLine("artistProjection: " + tags.Select(artistProjection).ToArray()[0]);
            #endregion

            Console.ReadLine();
        }

        // Create a method for a delegate.
        private static void SendOut(string message)
        {
            Console.WriteLine(message);
        }
    }
}

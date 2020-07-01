using ID3Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3Manager
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <remarks>https://dotnet-snippets.de/snippet/id3v1-mp3-tag-lesen-und-schreiben/426</remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button = new Button();
            button.Location = new Point (653, 71);
            button.Text = "Read";
            button.Height = 50;
            button.Click += Button_Click;
            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ReadId3();
        }

        private void SetStatus(string status)
        {
            MessageBox.Show(status);
            //Thread.Sleep(5000);
        }

        private void ReadId3()
        {
            ID3Tagger.NotifierDelegate handler = SetStatus;

            ID3Tagger id3Tagger = new ID3Tagger();
            id3Tagger.Read(handler);

            this.tbAlbum.Text = id3Tagger.Tag.Album;
            this.tbArtist.Text = id3Tagger.Tag.Artist;
            this.tbTitle.Text = id3Tagger.Tag.Title;
            this.tbComment.Text = id3Tagger.Tag.Comment;
            this.tbYear.Text = id3Tagger.Tag.Year;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

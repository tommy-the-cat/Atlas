using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Library that deals with 
// audio file attributes
using TagLib;

// Library for audio shit
using NAudio;
using NAudio.Wave;

namespace Atlas
{
    public partial class AtlasHome : Form
    {
        SongService songService = new SongService();
        private const string MUSICPATH = @"D:\music\";

        public AtlasHome()
        {
            InitializeComponent();
        }

        private void AtlasHome_Load(object sender, EventArgs e)
        {
            // Populate array of songs in the specified directory
            string[] files = Directory.GetFiles(MUSICPATH, "*.mp3");
            BindingSource musicBindingSource = new BindingSource();
            List<Song> songList = new List<Song> { };

            for (int i = 0; i < files.Length; i++)
            {
                Song song = new Song();
                TagLib.File tagFile = TagLib.File.Create(files[i]);

                song.Title = tagFile.Tag.Title;
                song.Path = files[i];
                if (tagFile.Tag.FirstPerformer != null)
                {
                    song.Artist = tagFile.Tag.FirstPerformer;
                }
                else
                {
                    song.Artist = "Unknown Artist";
                }
                songList.Add(song);
            }
            musicBindingSource.DataSource = songList;
            musicDataGridView.DataSource = musicBindingSource;
            musicDataGridView.Columns[1].Visible = false;
            musicDataGridView.Refresh();

            //  TODO :
            //    Add sorting mechanism for 
            //    DataGrdiView, possibly turn
            //    user sorting?
        }

        private void musicDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = musicDataGridView.Rows[rowIndex];
                Song song = new Song(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
                nowPlayingLabel.Text = String.Format("Now Playing : {0} By {1}", song.Title, song.Artist);
                songService.Play(song.Path);
            }
        }

        // The following should really be moved into buttons
        // designed properly, but for now it'll do.
        private void pausePictureBox_Click(object sender, EventArgs e)
        {
            songService.Pause();
        }

        private void stopPictureBox_Click(object sender, EventArgs e)
        {
            nowPlayingLabel.Text = "Now Playing : ";
            songService.Stop();
        }

    }
}

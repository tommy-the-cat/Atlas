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
using TagLib;

// audio shit
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

        /// <summary>
        /// Handles populating the DataGridView with all songs it finds in the 
        /// directory specified in 'MUSICPATH'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                song.Artist = tagFile.Tag.FirstAlbumArtist;

                songList.Add(song);
            }

            musicBindingSource.DataSource = songList;
            musicDataGridView.DataSource = musicBindingSource;
            musicDataGridView.Columns[1].Visible = false;
            musicDataGridView.Refresh();
        }

        /// <summary>
        /// Stops the currently playing track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopButton_Click(object sender, EventArgs e)
        {
            nowPlayingLabel.Text = "Now Playing : ";
            songService.Stop();
        }

        /// <summary>
        /// Pauses the currently playing track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pauseButton_Click(object sender, EventArgs e)
        {
            songService.Pause();
        }

        /// <summary>
        /// Plays the track that has been double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = musicDataGridView.Rows[rowIndex];

                Song song = new Song(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());

                nowPlayingLabel.Text = String.Format("Now Playing : {0} By {1}", song.Title, song.Artist);
                songService.Play(song.Path);
            }
            catch (Exception ex)
            {
                // throws index out of range
            }
        }

    }
}

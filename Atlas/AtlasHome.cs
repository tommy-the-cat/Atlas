using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// audio shit
using NAudio;
using NAudio.Wave;
using System.IO;

namespace Atlas
{
    public partial class AtlasHome : Form
    {
        SongService songService = new SongService();
        private const string MUSICPATH = "C:\\Users\\Public\\Music\\Sample Music\\";

        public AtlasHome()
        {
            InitializeComponent();
        }

        private void AtlasHome_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(MUSICPATH, "*.mp3");

            BindingSource musicBindingSource = new BindingSource();
            List<Song> songList = new List<Song> { };

            for (int i = 0; i < files.Length; i++)
            {
                Song song = new Song();
                song.Path = files[i];
                song.Title = files[i].Replace(MUSICPATH, "");
                songList.Add(song);
            }

            musicBindingSource.DataSource = songList;
            musicDataGridView.DataSource = musicBindingSource;
            musicDataGridView.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            nowPlayingLabel.Text = "";
            songService.Stop();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            songService.Pause();
        }

        private void musicDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = musicDataGridView.Rows[rowIndex];

            Song song = new Song(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());

            nowPlayingLabel.Text = song.Title;
            songService.Play(song.Path);
        }

    }
}

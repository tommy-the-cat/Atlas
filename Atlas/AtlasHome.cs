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

        public AtlasHome()
        {
            InitializeComponent();
        }

        private void AtlasHome_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles("C:\\Users\\Public\\Music\\Sample Music", "*.mp3");
            for (int i = 0; i < files.Length; i++)
            {
                //files[i] = files[i].Replace("C:\\Users\\Public\\Music\\Sample Music\\", "");
                musicListBox.Items.Add(files[i]);
            }
        }

        private void musicListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {           
             // TODO :                                                                                     
             // Replace the listbox with a datagridview.                                                   
             // I'll be able to create a hidden field in the datagridview to hold the path to the song     
             // and be able to display the song names without the stupid path                               
            
            nowPlayingLabel.Text = musicListBox.SelectedItem.ToString().Replace("C:\\Users\\Public\\Music\\Sample Music\\", "");
            songService.Play(musicListBox.SelectedItem.ToString());
            
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

    }
}

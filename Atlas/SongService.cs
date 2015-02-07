using NAudio.Wave;
using NAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas
{
    public class SongService
    {
        private IWavePlayer wavePlayer = new WaveOut();
        private AudioFileReader file;

        public void Play(string song)
        {
            file = new AudioFileReader(song);
            wavePlayer.Init(file);
            wavePlayer.Play();
        }

        public void Stop()
        {
            wavePlayer.Stop();
        }

        public void Pause()
        {
            wavePlayer.Pause();
        }

        
    }
}

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
            try
            {
                file = new AudioFileReader(song);
                wavePlayer.Init(file);
                wavePlayer.Play();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SongService: Broke on Play() : {0}", ex));
            }

        }

        public void Stop()
        {
            try
            {
                wavePlayer.Stop();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SongService: Broke on Stop() : {0}", ex));
            }

        }

        public void Pause()
        {
            try
            {
                wavePlayer.Pause();
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("SongService: Broke on Pause() : {0}", ex));
            }
        }        
    }
}

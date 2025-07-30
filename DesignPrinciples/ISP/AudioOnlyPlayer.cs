using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.ISP
{
    public class AudioOnlyPlayer : IAudioPlayerControls
    {
        public void PlayAudio(string audioFileName)
        {
            Console.WriteLine($"Playing audio file: {audioFileName}");
        }
        public void StopAudio()
        {
            Console.WriteLine("Audio playback stopped.");
        }
        public void IncreaseVolume(int volume)
        {
            Console.WriteLine("Increasing audio volume to: " + volume);
        }
        // No video-related methods implemented, adhering to ISP  
    }
}

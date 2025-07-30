using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.ISP
{
    public class ModernMediaPlayer : IVideoPlayerControls, IAudioPlayerControls
    {
        public void PlayVideo(string fileName)
        {
            Console.WriteLine("Playing video file: " + fileName);
        }

        public void StopVideo()
        {
            Console.WriteLine("Stopping video playback.");
        }

        public void AdjustBrightness(int level)
        {
            Console.WriteLine("Adjusting brightness to level: " + level);
        }

        public void DisplaySubtitles(string subtitles)
        {
            Console.WriteLine("Displaying subtitles: " + subtitles);
        }


        public void PlayAudio(string fileName)
        {
            Console.WriteLine("Playing audio file: " + fileName);
        }

        public void StopAudio()
        {
            Console.WriteLine("Stopping audio playback.");
        }
        public void IncreaseVolume(int level)
        {
            Console.WriteLine("Increasing volume to level: " + level);
        }
    }
}

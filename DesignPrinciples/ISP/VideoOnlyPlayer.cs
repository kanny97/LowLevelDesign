using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.ISP
{
    public class VideoOnlyPlayer : IVideoPlayerControls
    {
        //Implement IVideoPlayerControls methods below
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
            Console.WriteLine("Increasing brightness to level: " + level);
        }
        public void DisplaySubtitles(string subtitles)
        {
            Console.WriteLine("Displaying subtitles: " + subtitles);
        }
    }
}

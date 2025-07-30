using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.ISP
{
    public class ISPExample
    {
        public static void Main(string[] args)
        {
            ModernMediaPlayer player = new ModernMediaPlayer();
            player.PlayAudio("song.mp3");
            player.PlayVideo("movie.mp4");
            player.DisplaySubtitles("subtitle.srt");
            VideoOnlyPlayer videoPlayer = new VideoOnlyPlayer();
            videoPlayer.PlayVideo("documentary.mp4");
            videoPlayer.StopVideo();
            AudioOnlyPlayer audioPlayer = new AudioOnlyPlayer();
            audioPlayer.PlayAudio("podcast.mp3");
            audioPlayer.StopAudio();
        }
    }
}

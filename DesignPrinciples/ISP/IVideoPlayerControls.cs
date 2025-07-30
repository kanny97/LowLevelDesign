using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.ISP
{
    public interface IVideoPlayerControls
    {
        void PlayVideo(string fileName);
        void StopVideo();
        void AdjustBrightness(int level);
        void DisplaySubtitles(string subTitleFileName);
    }
}

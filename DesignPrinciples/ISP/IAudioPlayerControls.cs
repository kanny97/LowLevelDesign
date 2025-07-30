using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.ISP
{
    public interface IAudioPlayerControls
    {
        
        void PlayAudio(string fileName);
        void StopAudio();
        void IncreaseVolume(int volume);
    }
}

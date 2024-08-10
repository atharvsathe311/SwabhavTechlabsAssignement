using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State.Models
{
    public interface IMusicPlayerState
    {
        void PressPlay(MusicPlayer player);
        void PressPause(MusicPlayer player);
    }
}

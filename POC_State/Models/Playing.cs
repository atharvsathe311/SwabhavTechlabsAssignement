using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State.Models
{
    public class Playing : IMusicPlayerState
    {
        public void PressPlay(MusicPlayer player)
        {
            Console.WriteLine("Already playing.");
        }

        public void PressPause(MusicPlayer player)
        {
            Console.WriteLine("Pausing music.");
            player.SetState(new Paused());
        }
    }

}

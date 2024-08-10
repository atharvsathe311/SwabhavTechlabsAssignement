using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State.Models
{
    public class Paused : IMusicPlayerState
    {
        public void PressPlay(MusicPlayer player)
        {
            Console.WriteLine("Resuming music.");
            player.SetState(new Playing());
        }

        public void PressPause(MusicPlayer player)
        {
            Console.WriteLine("Already paused.");
        }
    }
}

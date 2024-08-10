using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State.Models
{
    public class MusicPlayer
    {
        private IMusicPlayerState _currentState;

        public MusicPlayer()
        {
            _currentState = new Paused(); // Start in paused state
        }

        public void SetState(IMusicPlayerState newState)
        {
            _currentState = newState;
        }

        public void PressPlay()
        {
            _currentState.PressPlay(this);
        }

        public void PressPause()
        {
            _currentState.PressPause(this);
        }
    }

}

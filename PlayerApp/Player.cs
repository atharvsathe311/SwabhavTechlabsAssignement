using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Player
    {
        private int _playerId;
        private string _playerName;
        private int _playerAge;
        
        public Player(int playerId, string playerName):this(playerId, playerName, 0)
        {

        }
        public Player(int playerId, string playerName, int playerAge) 
        {
            _playerId = playerId;
            _playerName = playerName;
            _playerAge = playerAge;
        }

        public int GetId()
        {
            return _playerId;
        }

        public string GetName()
        {
            return _playerName;
        }

        public int GetAge()
        {
            return _playerAge;
        }
        }
    }

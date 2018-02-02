using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myGameTest.Model;
using myGameTest.Model.Items;

namespace myGameTest {
    public class ViewModel {

        private Player _player;
        public Player CurrentPlayer() {
            if (_player == null) {
                _player = Player.DefaultPlayer();
            } else if (_player != null) {
                //Read from file
            }
            return _player;
        }

        public ViewModel() {
            
        }

    }
}

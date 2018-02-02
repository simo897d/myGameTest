using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myGameTest.Model;

namespace myGameTest {
    public class ViewModel {
        public ViewModel() {

        }

        private Player _player;
        private Monster _monster;
        public Player CurrentPlayer() {
            if (_player == null) {
                _player = Player.DefaultPlayer();
            } else if (_player != null) {
                //Read from file
            }
            return _player;
        }
        public Monster SetMonster { get { return _monster; } set { _monster = value; } }

        public Monster MonsterEncounter() {
            return _monster;
        }


        public string DidDamage() {
            string output;
            if (MonsterEncounter() == null) {
                output = "You're not in combat \n";
            } else {
                output = "You did " + CurrentPlayer().DoDamage().ToString() + " damage to" + MonsterEncounter().CreatureName + "\n";
            }
            return output;
        }

        public void MovePlayer() {

        }
    }
}

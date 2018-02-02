using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGameTest.Model {
    public class Monster : LivingCreatures {
        private Monster(int currentHitPoints, int maxHitPoints) : base(currentHitPoints, maxHitPoints) {

        }
    }
}

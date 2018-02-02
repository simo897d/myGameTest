using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using myGameTest.Model.Items;

namespace myGameTest.Model {
    public class Player : LivingCreatures {

        private Weapons _weapon;
        public Weapons CurrentWeapon { get { return _weapon; } set { _weapon = value; } }
        public BindingList<InventoryItem> ListOfInventory { get; set; }
        
        internal Player(int currentHitPoints, int maxHitPoints) : base(currentHitPoints, maxHitPoints) {
            ListOfInventory = new BindingList<InventoryItem>();
            }

        public static Player DefaultPlayer() {
            Player defPlayer = new Player(100, 100);

            defPlayer.ListOfInventory.Add(Swords.WoodenSword());
            return  defPlayer;
        }

        public void TakeDamage() {
            CurrentHitPoints = CurrentHitPoints - 5;
        }
        public void DoDamage() {

        }
    }
}

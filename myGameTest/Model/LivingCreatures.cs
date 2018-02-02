using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace myGameTest
{
    public class LivingCreatures : INotifyPropertyChanged
    {
        private int _currentHitPoints;

        public int CurrentHitPoints { get { return _currentHitPoints; }
            set { _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public int MaxHitPoints { get; set; }
        public bool IsDead { get { return CurrentHitPoints <= 0; } }

        public LivingCreatures(int currentHitPoints, int maxHitPoints) {
            CurrentHitPoints = currentHitPoints;
            MaxHitPoints = maxHitPoints;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

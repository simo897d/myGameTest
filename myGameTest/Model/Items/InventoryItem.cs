using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace myGameTest.Model.Items {
    public class InventoryItem : INotifyPropertyChanged{

        public InventoryItem(string itemID, int quantity) {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

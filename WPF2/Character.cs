using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF2
{
    class Character : INotifyPropertyChanged
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set 
            {
                if (name != value)
                {
                    name = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

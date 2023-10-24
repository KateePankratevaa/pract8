using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    class User: INotifyPropertyChanged
    {
        public string UserName { get; set; }
        public string Status { get; set;  }
        public DateTime LastLogin { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                if (PropertyChanged!=null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Username"));
            }
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string status;

        public string Staus
        { 
            get
            {
                return status;
            }
            set
            {
                status = value;
                NotifyPropertyChanged("Status");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//HomeWork 1
namespace Framework
{
    public class NotificationObject : INotifyPropertyChanged    
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler!=null)
            {
                handler(this, new PropertyChangedEventArgs( info ));
            }
        }
    }
}

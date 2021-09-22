using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnityIntergrationApp.Pages.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }
            storage = value;
            RaisePropertyChangedEvent(propertyName);
            return true;
        }
        
        protected bool SetObservableProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null) where T : INotifyPropertyChanged
        {
            if (storage != null)
            {
                storage.PropertyChanged -= new PropertyChangedEventHandler(RaisePropertyChangedEvent);
            }
            bool result = SetProperty(ref storage, value);
            if (storage != null)
            {
                storage.PropertyChanged += new PropertyChangedEventHandler(RaisePropertyChangedEvent);
            }
            return result;
        }

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void RaisePropertyChangedEvent(object sender, PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(sender, eventArgs);
        }
    }
}

using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnityIntergrationApp.Common
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }
            storage = value;
            RaisePropertyChangedEvent(propertyName);
            return true;
        }

        protected bool SetObservableCollection<T>(ref T storage, T value, [CallerMemberName] string propertyName = null) where T : INotifyCollectionChanged
        {
            if (storage != null)
            {
                storage.CollectionChanged -= new NotifyCollectionChangedEventHandler(RaisePropertyChangedEvent);
            }
            bool result = SetProperty(ref storage, value);
            if (storage != null)
            {
                storage.CollectionChanged += new NotifyCollectionChangedEventHandler(RaisePropertyChangedEvent);
            }
            return result;
        }

        protected bool SetObservableProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null) where T : INotifyPropertyChanged
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

        protected void RaisePropertyChangedEvent(object sender, NotifyCollectionChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("Collection Changed"));
        }
    }
}

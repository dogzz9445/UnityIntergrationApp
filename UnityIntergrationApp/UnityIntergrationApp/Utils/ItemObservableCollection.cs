using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIntergrationApp.Utils
{
    class ItemObservableCollection<T> : ObservableCollection<T>
        where T : INotifyPropertyChanged
    {
        public ItemObservableCollection() : base() 
        {
            Initialize();
        }
        public ItemObservableCollection(List<T> list) : base((list != null) ? new List<T>(list.Count) : list)
        {
            Initialize();
            CopyFrom(list);
        }

        public ItemObservableCollection(IEnumerable<T> enumerable) : base()
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException("Error occurs IEnumerable constructor in ItemObservableCollection");
            }
            Initialize();
            CopyFrom(enumerable);
        }

        private void Initialize()
        {
            this.CollectionChanged += (s, e) => OnItemCollectionChanged(s, e);
        }

        private void CopyFrom(IEnumerable<T> enumerable)
        {
            IList<T> items = Items;
            if (enumerable != null && items != null)
            {
                using (IEnumerator<T> enumerator = enumerable.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        items.Add(enumerator.Current);
                    }
                }
            }
        }

        private void OnItemCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Object item in e.NewItems)
                {
                    (item as INotifyPropertyChanged).PropertyChanged += new PropertyChangedEventHandler(OnItemPropertyChanged);
                }
            }
            if (e.OldItems != null)
            {
                foreach (Object item in e.OldItems)
                {
                    (item as INotifyPropertyChanged).PropertyChanged -= new PropertyChangedEventHandler(OnItemPropertyChanged);
                }
            }
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ItemPropertyChanged != null)
            {
                ItemPropertyChanged(sender, e);
            }
        }
        
        public event PropertyChangedEventHandler ItemPropertyChanged;
    }
}

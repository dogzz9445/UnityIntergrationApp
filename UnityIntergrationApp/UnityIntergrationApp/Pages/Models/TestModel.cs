using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityIntergrationApp.Common;

namespace UnityIntergrationApp.Pages.Models
{
    public class TestModel : BindableBase
    {
        private string _title;
        private ObservableCollection<float> _data;

        public string Title { get => _title; set => SetProperty(ref _title, value); }
        public ObservableCollection<float> Data { get => _data; set => SetObservableProperty(ref _data, value); }

        public TestModel()
        {
            Title = "테스트 모델";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityIntergrationApp.Common;
using UnityIntergrationApp.Pages.Models;

namespace UnityIntergrationApp.Pages.ViewModels
{
    public class TestViewModel : BindableBase
    {
        private ItemObservableCollection<TestModel> m_models;
        public ItemObservableCollection<TestModel> Models { get => m_models; set => m_models = value; }

        public TestViewModel()
        {
            m_models = new ItemObservableCollection<TestModel>();
        }

        public void TestInitialize()
        {
            m_models.Add(new TestModel()
            {
                Data = new ObservableCollection<float>()
                {
                    1.0f, 2.0f, 3.0f
                },
            });
        }
    }
}

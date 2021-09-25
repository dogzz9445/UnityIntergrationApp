using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityIntergrationApp.Common;
using UnityIntergrationApp.Pages.Models;

namespace UnityIntergrationApp.Pages.ViewModels
{
    public class ScenarioViewModel : BindableBase
    {
        private ItemObservableCollection<Scenario> m_scenarios;
        public ItemObservableCollection<Scenario> Scenarios { get => m_scenarios; set => m_scenarios = value; }

        public ScenarioViewModel()
        {
            m_scenarios = new ItemObservableCollection<Scenario>();
        }
    }
}

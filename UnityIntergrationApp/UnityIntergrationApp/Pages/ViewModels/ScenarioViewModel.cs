using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityIntergrationApp.Common;
using UnityIntergrationApp.Pages.Models;

namespace UnityIntergrationApp.Pages.ViewModels
{
    public class ScenarioViewModel : BaseViewModel
    {
        public ItemObservableCollection<Scenario> m_scenarios;
        public ItemObservableCollection<Scenario> Scenarios { get; set; }

        public ScenarioViewModel()
        {
            m_scenarios = new ItemObservableCollection<Scenario>();
        }
    }
}

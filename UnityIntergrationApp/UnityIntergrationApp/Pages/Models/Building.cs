using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityIntergrationApp.Common;

namespace UnityIntergrationApp.Pages.Models
{
    public class Building : BindableBase
    {
        private float m_buildingName;
        private float m_numFloors;
        private float m_maxYFloorPlan;
        private float m_minYFloorPlan;
        private ItemObservableCollection<FloorPlan> m_floorPlans;

        public ItemObservableCollection<FloorPlan> FloorPlans
        {
            get => m_floorPlans;
            set => SetObservableCollection(ref m_floorPlans, value);
        }
    }

    public class FloorPlan : BindableBase
    {

    }
}

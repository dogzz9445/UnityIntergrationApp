using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIntergrationApp.Pages.Models
{
    public class Building : BaseModel
    {
        private ObservableDictionary<string, float> m_yFloorPlans;

        public Dictionary<string, float> YFloorPlans
        {
            get => m_yFloorPlans;
            set
            {
                m_yFloorPlans = value;
                RaisePropertyChangedEvent("YFloorPlans");
            }
        }
    }
}

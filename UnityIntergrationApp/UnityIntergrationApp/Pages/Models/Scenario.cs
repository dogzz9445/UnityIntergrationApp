using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIntergrationApp.Pages.Models
{
    public class Scenario
    {
        private string m_title;
        private string m_description;
        private string m_imageFilePath;
        private string m_fbxFilePath;
        private Dictionary<string, float> m_yFloorPlans;

        public string Title { get => m_title; set => m_title = value; }
        public string Description { get => m_description; set => m_description = value; }
        public string ImageFilePath { get => m_imageFilePath; set => m_imageFilePath = value; }
        public string FbxFilePath { get => m_fbxFilePath; set => m_fbxFilePath = value; }
        public Dictionary<string, float> YFloorPlans { get => m_yFloorPlans; set => m_yFloorPlans = value; }

        public Scenario()
        {

        }
    }
}

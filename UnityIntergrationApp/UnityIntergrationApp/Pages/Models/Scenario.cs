using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIntergrationApp.Pages.Models
{
    public class Scenario : BaseModel
    {
        private string m_title;
        private string m_description;
        private string m_imageFilePath;
        private string m_fbxFilePath;

        public string Title
        {
            get => m_title;
            set
            {
                m_title = value;
                RaisePropertyChangedEvent("Title");
            }
        }
        public string Description
        {
            get => m_description;
            set
            {
                m_description = value;
                RaisePropertyChangedEvent("Description");
            }
        }
        public string ImageFilePath
        {
            get => m_imageFilePath;
            set
            {
                m_imageFilePath = value;
                RaisePropertyChangedEvent("ImageFilePath");
            }
        }
        public string FbxFilePath
        {
            get => m_fbxFilePath;
            set
            {
                m_fbxFilePath = value;
                RaisePropertyChangedEvent("FbxFilePath");
            }
        }

        public Scenario()
        {
        }
    }
}

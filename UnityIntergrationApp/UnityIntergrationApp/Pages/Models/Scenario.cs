using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityIntergrationApp.Common;

namespace UnityIntergrationApp.Pages.Models
{
    public class Scenario : BindableBase
    {
        private string m_title;
        private string m_description;
        private string m_imageFilePath;
        private string m_fbxFilePath;
        private Building m_building;

        public string Title
        {
            get => m_title;
            set => SetProperty(ref m_title, value);
        }
        public string Description
        {
            get => m_description;
            set => SetProperty(ref m_description, value);
        }
        public string ImageFilePath
        {
            get => m_imageFilePath;
            set => SetProperty(ref m_imageFilePath, value);
        }
        public string FbxFilePath
        {
            get => m_fbxFilePath;
            set => SetProperty(ref m_fbxFilePath, value);
        }

        public Building Building
        {
            get => m_building;
            set => SetObservableProperty(ref m_building, value);
        }

        public Scenario()
        {
        }
    }
}

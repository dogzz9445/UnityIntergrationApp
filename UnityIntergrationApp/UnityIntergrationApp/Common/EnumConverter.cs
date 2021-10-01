using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
// using System.Windows.Data;
using Microsoft.UI.Xaml.Data;

namespace UnityIntergrationApp.Common
{
    public class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value;
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Enum returnValue = default(Enum);
            if (parameter is Type && value != null)
            {
                returnValue = (Enum)Enum.Parse((Type)parameter, value.ToString());
            }
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            Enum returnValue = default(Enum);
            if (parameter is Type && value != null)
            {
                returnValue = (Enum)Enum.Parse((Type)parameter, value.ToString());
            }
            return returnValue;
        }
    }

    public class EnumValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Enum enumValue = default(Enum);
            if (parameter is Type)
            {
                enumValue = (Enum)Enum.Parse((Type)parameter, value.ToString());
            }
            return value;
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Enum enumValue = default(Enum);
            if (parameter is Type)
            {
                enumValue = (Enum)Enum.Parse((Type)parameter, value.ToString());
            }
            return value;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int returnValue = 0;
            if (parameter is Type)
            {
                returnValue = (int)Enum.Parse((Type)parameter, value.ToString());
            }
            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            int returnValue = 0;
            if (parameter is Type)
            {
                returnValue = (int)Enum.Parse((Type)parameter, value.ToString());
            }
            return returnValue;
        }
    }
}

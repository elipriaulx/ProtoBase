using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProtoBase.Wpf.ValueConverters
{
    public class BooleanToVisibilityValueConverter : IValueConverter
    {
        #region Public Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as bool? ?? false ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as Visibility? == Visibility.Visible;
        }

        #endregion
    }
}

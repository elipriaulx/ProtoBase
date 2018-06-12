using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProtoBase.Wpf.ValueConverters
{
    public class BooleanToInvertedVisibilityValueConverter : IValueConverter
    {
        #region Public Methods

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as bool? ?? false ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as Visibility? != Visibility.Visible;
        }

        #endregion
    }
}

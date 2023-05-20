using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Data;

namespace View.Converters
{
    public class GameLostMineConverter : IValueConverter
    {
        public object Mine { get; set; }
        public object NotMine { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value is not bool isMine) return null;
            return isMine ? Mine : NotMine;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
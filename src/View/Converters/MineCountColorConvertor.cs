using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View.Converters
{
    class MineCountColorConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var mineCount = (int)value;

            switch (mineCount)
            {
                case 0:
                    return "navy";
                case 1:
                    return "navy";
                case 2:
                    return "green";
                case 3:
                    return "red";
                case 4:
                    return "orange";
                case 5:
                    return "violet";
                case 6:
                    return "pink";
                case 7:
                    return "black";
                case 8:
                    return "gray";
                
                default:
                    throw new ArgumentException("Invalid GameStatus value", "value");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

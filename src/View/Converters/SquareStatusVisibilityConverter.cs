using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
    class SquareStatusVisibilityConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SquareStatus status = (SquareStatus)value;

            switch (status)
            {
                case SquareStatus.Flagged:
                    return "Hidden";
                case SquareStatus.Covered:
                    return "Hidden";
                case SquareStatus.Mine:
                    return "Hidden";
                case SquareStatus.Uncovered:
                    return "Visible";
                default:
                    throw new ArgumentException("Invalid SquareStatus value", "value");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

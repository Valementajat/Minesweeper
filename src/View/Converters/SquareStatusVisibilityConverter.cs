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
            
            var statuss = (Square)value;
            SquareStatus status = statuss.Status;
            var MC = statuss.NeighboringMineCount;
           
            return status switch
            {
                SquareStatus.Flagged => "Hidden",
                SquareStatus.Covered => "Hidden",
                SquareStatus.Mine => "Hidden",
                SquareStatus.Uncovered => MC switch
                {
                    0 => "Hidden",
                    _ => "Visible",
                },
                _ => throw new ArgumentException("Invalid SquareStatus value", "value"),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

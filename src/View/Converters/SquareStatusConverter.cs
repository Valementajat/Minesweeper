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
   
    public class SquareStatusConverter : IValueConverter
    {
        public object Uncovered { get; set; }
        public object Covered { get; set; }
        public object Flagged { get; set; }
        public object Mine { get; set; }



        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
             
            switch (value)
            {
                case SquareStatus.Flagged:
                    return Flagged;
                case SquareStatus.Covered:
                    return Covered;
                case SquareStatus.Mine:
                    return Mine;
                case SquareStatus.Uncovered:
                    return Uncovered;
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
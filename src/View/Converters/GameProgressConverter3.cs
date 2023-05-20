using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    class GameProgressConverter3 : IMultiValueConverter
    {
        public object Mine { get; set; }
        public object NotMine { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (GameStatus)values[0];
            var mineCount = (int)values[1];
            if ((bool)values[2])
            {
                return Visibility.Hidden;
            }

            if (status != GameStatus.InProgress)
            {
                if (mineCount == 0) {
               
                    return Visibility.Hidden; 
                }
                else
                {
                    return Visibility.Visible; 
                }

            } else
            {
                return Visibility.Hidden;

            }

            
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

       
}

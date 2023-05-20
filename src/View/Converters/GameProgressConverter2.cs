

using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace View.Converters
{
    class GameProgressConverter2 : IValueConverter
    {
        public object InProgress { get; set; }
        public object Won { get; set; }
        public object Lost { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (GameStatus)value;

            switch (status)
            {
                case GameStatus.Won:
                    return Won;
                case GameStatus.Lost:
                    return Lost;
                case GameStatus.InProgress:
                    return InProgress;
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

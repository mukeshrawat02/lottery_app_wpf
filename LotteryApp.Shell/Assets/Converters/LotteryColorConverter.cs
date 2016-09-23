using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace LotteryApp.Shell.Assets.Converters
{
    public class LotteryColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            /*
             1-9 Red
             10-19 Blue
             20-29 Green
             30-39 Orange
             40-49 Purple

             */
            var number = System.Convert.ToInt32(value);
            if (number >= 1 && number <= 9) return Brushes.Red;
            if (number >= 10 && number <= 19) return Brushes.Blue;
            if (number >= 20 && number <= 29) return Brushes.Green;
            if (number >= 30 && number <= 39) return Brushes.Orange;

            return Brushes.Purple;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

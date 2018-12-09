﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Trailexplorers
{
    public class PointConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            System.Drawing.Point dp = (System.Drawing.Point)value;
            return new System.Windows.Point(dp.X, dp.Y);
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            System.Windows.Point wp = (System.Windows.Point)value;
            return new System.Drawing.Point((int)wp.X, (int)wp.Y);
        }

    }
}

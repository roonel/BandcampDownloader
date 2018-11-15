﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace BandcampDownloader {

    /// <summary>
    /// Transforms a double to its percent value. For instance: "0.05 → 5".
    /// </summary>
    public class DoubleToPercentConverter: IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return Double.Parse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture) * 100; // 0.05 → 5%
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return Double.Parse(value.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture) / 100; // 5% → 0.05
        }
    }
}
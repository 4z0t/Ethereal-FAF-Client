using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace beta.Infrastructure.Converters
{
    class ClipGeometryConverter : IMultiValueConverter
    {
        public bool IsFreezed { get; set; }
        /// <summary>
        /// Get pathGeometry with borders
        /// </summary>
        /// <param name="values">Width and Height</param>
        /// <param name="parameter">Corner radius: X or X X X X</param>
        /// <returns></returns>
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            double width = (double)values[0];
            double height = (double)values[1];

            string[] strCorners = parameter.ToString().Split();

            Point topLeft = new();
            Point topRight = new();
            Point bottomLeft = new();
            Point bottomRight = new();

            if (strCorners.Length == 4)
            {

            }
            else
            {

            }

            PathGeometry pathGeometry = new();
            PathFigure pathFigure = new();

            if (IsFreezed) pathGeometry.Freeze();
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

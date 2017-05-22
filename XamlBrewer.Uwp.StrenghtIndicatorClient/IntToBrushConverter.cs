using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace XamlBrewer.Uwp.StrenghtIndicatorClient
{
    public class IntToBrushConverter : IValueConverter
    {
        private List<SolidColorBrush> _brushes => new List<SolidColorBrush>
        {
            new SolidColorBrush(Color.FromArgb(255, 136, 130, 168)),
            new SolidColorBrush(Colors.SeaGreen),
            new SolidColorBrush(Colors.LightGreen),
            new SolidColorBrush(Colors.Khaki),
            new SolidColorBrush(Colors.Orange),
            new SolidColorBrush(Colors.Firebrick)
        };

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return _brushes[int.Parse(value.ToString())];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}


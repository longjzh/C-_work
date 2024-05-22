using System.Windows;
using System.Windows.Media;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (labelColorDisplay != null)
            {
                var color = Color.FromArgb(
                    (byte)sliderAlpha.Value,
                    (byte)sliderRed.Value,
                    (byte)sliderGreen.Value,
                    (byte)sliderBlue.Value);
                labelColorDisplay.Background = new SolidColorBrush(color);
            }
        }
    }
}
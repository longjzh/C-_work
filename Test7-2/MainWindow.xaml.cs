using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            this.DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spNumbers.Children.Clear();
            Random rand = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = rand.Next(501);
                TextBox tb = new TextBox { Width = 25, Text = numbers[i].ToString() };
                spNumbers.Children.Add(tb);
            }

            _viewModel.Min = numbers.Min();
            _viewModel.Avg = numbers.Average();
            _viewModel.Max = numbers.Max();
        }

        private void tbMin_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int value;
                bool isNumeric = int.TryParse(textBox.Text, out value);
                if (isNumeric && value > 255)
                {
                    textBox.Background = Brushes.Red;
                }
                else
                {
                    textBox.Background = Brushes.White;
                }
            }
        }


        private void tbMax_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int value;
                bool isNumeric = int.TryParse(textBox.Text, out value);
                if (isNumeric && value > 255)
                {
                    textBox.Background = Brushes.Red;
                }
                else
                {
                    textBox.Background = Brushes.White;
                }
            }
        }

        private void tbAvg_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                double value;
                bool isNumeric = double.TryParse(textBox.Text, out value);
                if (isNumeric && value > 255.00)
                {
                    textBox.Background = Brushes.Red;
                }
                else
                {
                    textBox.Background = Brushes.White;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtonTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        Color[] colors = new Color[]
        {
          Colors.Red,
          Colors.Blue,
          Colors.Green,
        };

        private void button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                Stack1.Children.Remove(btn);
                this.Title = btn.Content.ToString();
            }
        }

        private void button4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                Stack2.Children.Remove(btn);
                this.Title = btn.Content.ToString();
            }
        }

        private void button1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
                Random random = new Random();
                btn.Background = new SolidColorBrush(colors[random.Next(0, 3)]);
            }
        }
    }
}

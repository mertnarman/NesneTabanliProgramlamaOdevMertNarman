using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Modul9_Unite3
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 

            label1.Visibility = Visibility.Hidden;
        }

        private void wnd_MouseMove(object sender, MouseEventArgs e)
        {
            double x = e.GetPosition(wnd).X;
            double y = e.GetPosition(wnd).Y;

            Canvas.SetLeft(label1, x + 2);
            Canvas.SetTop(label1, y + 2);

            label1.Content = x.ToString("0") + " * " + y.ToString("0");
        }

        private void wnd_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.Visibility = Visibility.Visible;
        }

        private void wnd_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.Visibility = Visibility.Hidden;
        }
    }
}

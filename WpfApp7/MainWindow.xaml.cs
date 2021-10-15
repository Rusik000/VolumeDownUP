using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp7.BridgePattern;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Value2 = 10;
        public MainWindow()
        {
            InitializeComponent();
            Value2 = (int)SliderSound.Value;
            SliderSound.Minimum = 10;
            SliderSound.Maximum = 50;
            SliderSound.TickPlacement = System.Windows.Controls.Primitives.TickPlacement.BottomRight;
            SliderSound.TickFrequency = 10;
            SliderLabel.Content = SliderSound.Value.ToString();
        }

        private void Mute_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            var wih = new WindowInteropHelper(window);
            IntPtr hWnd = wih.Handle;
            Mute computer = new Mute();
            computer.Muting(hWnd);
        }

        private void Increase_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            var wih = new WindowInteropHelper(window);
            IntPtr hWnd = wih.Handle;
            Mute computer = new Mute();
            computer.Increase(hWnd);
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            var wih = new WindowInteropHelper(window);
            IntPtr hWnd = wih.Handle;
            Mute computer = new Mute();
            computer.Decrease(hWnd);
        }

        private void Mute_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (SliderSound.Value > Value2)
            {
                Window window = Window.GetWindow(this);
                var wih = new WindowInteropHelper(window);
                IntPtr hWnd = wih.Handle;
                Mute computer = new Mute();
                computer.Increase(hWnd);
             SliderLabel.Content = (Convert.ToInt32(SliderSound.Value)).ToString();
            }
            if (SliderSound.Value < Value2)
            {
                Window window = Window.GetWindow(this);
                var wih = new WindowInteropHelper(window);
                IntPtr hWnd = wih.Handle;
                Mute computer = new Mute();
                computer.Decrease(hWnd);
             SliderLabel.Content = (Convert.ToInt32(SliderSound.Value)).ToString();
            }

            Value2 = SliderSound.Value;

        }

        private void OffOn_Checked(object sender, RoutedEventArgs e)
        {
            SliderSound.Visibility = Visibility.Collapsed;
            SliderLabel.Visibility = Visibility.Collapsed;
            lbl1Vol.Visibility = Visibility.Collapsed;
           // SliderSound.Visibility = Visibility.Collapsed;
        }
    }
}

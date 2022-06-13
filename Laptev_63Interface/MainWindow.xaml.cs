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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laptev_63Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Real real;
        private Integer integer;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            integer = new Integer(int.Parse(i1.Text),
                                  int.Parse(i2.Text));

            RES1.Text = integer.Print();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            real = new Real(double.Parse(r1.Text),
                            double.Parse(r2.Text));
            RES2.Text = real.Print();
        }
    }
}

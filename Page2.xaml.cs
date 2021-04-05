using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Proekt
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        private int numP = 0;
        public Page2()
        {
            InitializeComponent();
        }
        public Page2(int Num)
        {
            InitializeComponent();
            numP = Num;

        }

        private void Test_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader pr = new StreamReader($@"C:\Users\WSR\source\repos\Proekt\less\less{numP}.txt");
            ur.Text = pr.ReadToEnd();
        }
    }
}

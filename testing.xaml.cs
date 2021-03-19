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
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.IO;

namespace Proekt
{
    /// <summary>
    /// Логика взаимодействия для testing.xaml
    /// </summary>
    public partial class testing : Window
    {
        private int Num = 1;
        public testing()
        {
            InitializeComponent();
            frameT.Navigate(new Page2());
        }

        private void frameT_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}

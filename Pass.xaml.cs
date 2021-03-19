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

namespace Proekt
{
    /// <summary>
    /// Логика взаимодействия для Pass.xaml
    /// </summary>
    public partial class Pass : Window
    {
        public Pass()
        {
            InitializeComponent();
        }

        private void kod_perehod(object sender, RoutedEventArgs e)
        {
            Kod_pass Kod_pass = new Kod_pass();
            Kod_pass.ShowDialog();
        }
    }
}

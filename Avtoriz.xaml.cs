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

namespace Proekt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Avtoriz : Window
    {
       
        private void vhod1_Click(object sender, RoutedEventArgs e)
        {
            glav glav = new glav();
            this.Close();
            glav.ShowDialog();
        }

        private void but_reg(object sender, RoutedEventArgs e)
        {
            reg reg = new reg();
            this.Close();
            reg.ShowDialog();
        }

        private void zab_par(object sender, RoutedEventArgs e)
        {
            Pass Pass = new Pass();
            this.Close();
            Pass.ShowDialog();
        }
    }
}

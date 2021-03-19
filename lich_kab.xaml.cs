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
    /// Логика взаимодействия для lich_kab.xaml
    /// </summary>
    public partial class lich_kab : Window
    {
        public lich_kab()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            glav glav = new glav();
            this.Close();
            glav.ShowDialog();
        }

        private void vibor_Click(object sender, RoutedEventArgs e)
        {
            admVhod admVhod = new admVhod();
            this.Close();
            admVhod.ShowDialog();
        }
    }
}

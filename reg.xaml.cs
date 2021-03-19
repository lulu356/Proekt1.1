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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        public reg()
        {
            InitializeComponent();
        }

        private void vhod2(object sender, RoutedEventArgs e)
        {
            glav glav = new glav();
            this.Close();
            glav.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz Avtoriz = new Avtoriz();
            this.Close();
            Avtoriz.ShowDialog();
        }

    }
}

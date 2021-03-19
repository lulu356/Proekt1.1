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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proekt
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private int num = 0;
        public Page1()
        {
            InitializeComponent();
           

        }
        public Page1(int pageNum)
        {
            InitializeComponent();
            num = pageNum;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\Proekt\less\less{num}.txt");
            ur.Text = sr.ReadToEnd();
        }
    }
}

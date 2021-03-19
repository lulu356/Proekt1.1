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
using System.IO;


namespace Proekt
{
    /// <summary>
    /// Логика взаимодействия для avtoriz.xaml
    /// </summary>
    public partial class glav : Window

    {
        private int pageNum = 1; 
        public glav()
        {
            InitializeComponent();
            frameM.Navigate(new Page1());

        }

        private void LK(object sender, RoutedEventArgs e)
        {
            lich_kab lich_kab = new lich_kab();
            this.Close();
            lich_kab.ShowDialog();
        }
        private int num =1;
        public glav(int pageNum)
        {
            InitializeComponent();
            num = pageNum;
            
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader($@"C:\Users\WSR\source\repos\Proekt\less\less{num}.txt");
            ur.Text = sr.ReadToEnd();
        }

        private void less_1_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(1));
            this.less_1_Copy.Visibility = Visibility.Hidden;
        }

        private void less_2_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(2));
            this.less_2_Copy.Visibility = Visibility.Hidden;
        }

        private void less_3_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(3));
            this.less_3_Copy.Visibility = Visibility.Hidden;
        }

        private void less_4_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(4));
            this.less_4_Copy.Visibility = Visibility.Hidden;
        }

        private void less_5_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(5));
            this.less_5_Copy.Visibility = Visibility.Hidden;
        }

        private void less_6_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(6));
            this.less_6_Copy.Visibility = Visibility.Hidden;
        }

        private void less_7_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(7));
            this.less_7_Copy.Visibility = Visibility.Hidden;
        }

        private void less_8_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(8));
            this.less_8_Copy.Visibility = Visibility.Hidden;
        }

        private void less_9_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(9));
            this.less_9_Copy.Visibility = Visibility.Hidden;
        }

        private void less_10_Click(object sender, RoutedEventArgs e)
        {
            frameM.Navigate(new Page1(10));
            this.less_10_Copy.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Avtoriz Avtoriz = new Avtoriz();
            this.Close();
            Avtoriz.ShowDialog();
        }

        private void test_1_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_2_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_3_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_4_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_5_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_6_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_7_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_8_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_9_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }

        private void test_10_Copy_Click(object sender, RoutedEventArgs e)
        {
            testing testing = new testing();
            this.Close();
            testing.ShowDialog();
        }
    }
}

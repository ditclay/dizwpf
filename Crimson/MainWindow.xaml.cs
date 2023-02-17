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

namespace Crimson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Manager.navi.Navigate(new siz1());
            siz1 siz = new siz1();
            siz.Show();
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            sizsiz siz = new sizsiz();
            siz.Show();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            dangerzone window = new dangerzone();
            window.Show();
        }
    }
}

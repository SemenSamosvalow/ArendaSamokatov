using ArendaSamokatov.Pages;
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

namespace ArendaSamokatov
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

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnAccount_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AccountPage());
        }

        private void BtnCatalogue_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CataloguePage());
        }

        private void BtnCart_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate (new CartPage());
        }
    }
}

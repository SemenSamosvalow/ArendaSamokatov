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

namespace ArendaSamokatov.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        //private void BtnEnter_Click(object sender, RoutedEventArgs e)
        //{
        //    var userAuth = ClassHelper.EF.Context.Client.ToList().
        //        Where(i => i.Login == TbLogin.Text && i.Password == PbPassword.Password).FirstOrDefault();

        //    if (userAuth != null)
        //    {
        //        ClassHelper.UserDataClass.client = userAuth;

        //        MainWindow mainWindow = new MainWindow();
        //        mainWindow.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Пользователя не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

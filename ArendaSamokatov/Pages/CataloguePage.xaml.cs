using ArendaSamokatov.ClassHelper;
using ArendaSamokatov.DB;
using ArendaSamokatov.Windows;
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

namespace ArendaSamokatov.Pages
{
    /// <summary>
    /// Логика взаимодействия для CataloguePage.xaml
    /// </summary>
    public partial class CataloguePage : Page
    {
        public CataloguePage()

        {
            
            InitializeComponent();
            GetListScooters();
        }

        private void GetListScooters()
        {
            LvCatalogue.ItemsSource = ClassHelper.EF.Context.Scooter.ToList();
        }

        private void BtnAddCart_Click(object sender, RoutedEventArgs e)
        {
            var button  = sender as Button;
            if (button == null )
            {
                return;
            }
            var scooter = button.DataContext as DB.Scooter;

            CartClass.Scooters.Add( scooter );

            MessageBox.Show($"Самокат {scooter.ModelName} добавлен в корзину!");
        }

        private void BtnAddScooter_Click(object sender, RoutedEventArgs e)
        {
            AddScooterWindow addScooterWindow = new AddScooterWindow();
            addScooterWindow.Show();
        }
    }
}

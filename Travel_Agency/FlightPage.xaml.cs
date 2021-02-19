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

namespace Travel_Agency
{
    /// <summary>
    /// Логика взаимодействия для FlightPage.xaml
    /// </summary>
    public partial class FlightPage : Page
    {
        public FlightPage()
        {
            InitializeComponent();
            DGridFlight.ItemsSource = TravelAgency1Entities.GetContext().Рейсы.ToList();
        }

        private void BtnEdit10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd10_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new FlightEdit(null));
        }

        private void BtnDelete10_Click(object sender, RoutedEventArgs e)
        {
            var HotelsForRemoving = DGridFlight.SelectedItems.Cast<Рейсы>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {HotelsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TravelAgency1Entities.GetContext().Рейсы.RemoveRange(HotelsForRemoving);
                    TravelAgency1Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DGridFlight.ItemsSource = TravelAgency1Entities.GetContext().Рейсы.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}

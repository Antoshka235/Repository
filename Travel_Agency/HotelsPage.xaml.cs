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

namespace Travel_Agency
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
            DGridHotel.ItemsSource = TravelAgency1Entities.GetContext().Отель.ToList();
        }

        private void BtnAdd7_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditHotels(null));
        }

        private void BtnDelete7_Click(object sender, RoutedEventArgs e)
        {
            var HotelsForRemoving = DGridHotel.SelectedItems.Cast<Отель>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {HotelsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TravelAgency1Entities.GetContext().Отель.RemoveRange(HotelsForRemoving);
                    TravelAgency1Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DGridHotel.ItemsSource = TravelAgency1Entities.GetContext().Отель.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit7_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new EditHotels((sender as Button).DataContext as Отель));
        }
    }
}

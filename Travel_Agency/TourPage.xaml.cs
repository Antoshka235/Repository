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
    /// Логика взаимодействия для TourPage.xaml
    /// </summary>
    public partial class TourPage : Page
    {
        public TourPage()
        {
            InitializeComponent();
            DGridTour.ItemsSource = TravelAgency1Entities.GetContext().Тур.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TourEdit(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var TourForRemoving = DGridTour.SelectedItems.Cast<Тур>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {TourForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TravelAgency1Entities.GetContext().Тур.RemoveRange(TourForRemoving);
                    TravelAgency1Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DGridTour.ItemsSource = TravelAgency1Entities.GetContext().Тур.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit9_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TourEdit((sender as Button).DataContext as Тур));
        }
    }
}

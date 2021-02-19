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
    /// Логика взаимодействия для CommentPage.xaml
    /// </summary>
    public partial class CommentPage : Page
    {
        public CommentPage()
        {
            InitializeComponent();
            DGridComment.ItemsSource = TravelAgency1Entities.GetContext().Коментарий_о_отеле.ToList();
        }

        private void BtnDelete9_Click(object sender, RoutedEventArgs e)
        {
            var CommentForRemoving = DGridComment.SelectedItems.Cast<Коментарий_о_отеле>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {CommentForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TravelAgency1Entities.GetContext().Коментарий_о_отеле.RemoveRange(CommentForRemoving);
                    TravelAgency1Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!");

                    DGridComment.ItemsSource = TravelAgency1Entities.GetContext().Коментарий_о_отеле.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            
        }

        private void BtnAdd9_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CommentEdit());
        }

        private void BtnEdit9_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

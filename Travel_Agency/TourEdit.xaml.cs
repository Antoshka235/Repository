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
    /// Логика взаимодействия для TourEdit.xaml
    /// </summary>
    public partial class TourEdit : Page
    {
        private Тур _currentTour = new Тур();

        public TourEdit(Тур seletedTour)
        {
            InitializeComponent();

            if (seletedTour != null)
                _currentTour = seletedTour;

            DataContext = _currentTour;
            ComboActive.Items.Add("True");
            ComboActive.Items.Add("False");
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentTour.Количество_билетов == null)
                errors.AppendLine("Укажите кол-во билетов");
            if (string.IsNullOrWhiteSpace(_currentTour.Название))
                errors.AppendLine("Укажите тур");
            if (string.IsNullOrWhiteSpace(_currentTour.Описание))
                errors.AppendLine("Укажите описание");
            if (_currentTour.Стоимость == null)
                errors.AppendLine("Укажите стоимость");
            if (_currentTour.Актуальность == null)
                errors.AppendLine("Выберите актуальность");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentTour.ID == 0)
                TravelAgency1Entities.GetContext().Тур.Add(_currentTour);

            try
            {
                TravelAgency1Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

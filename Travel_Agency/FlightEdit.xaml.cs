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
    /// Логика взаимодействия для FlightEdit.xaml
    /// </summary>
    public partial class FlightEdit : Page
    {
        private Рейсы _currentFlight = new Рейсы();
        public FlightEdit(Рейсы selectedFlight)
        {
            InitializeComponent();

            if (selectedFlight != null)
                _currentFlight = selectedFlight;

            DataContext = _currentFlight;
            ComboPlace.ItemsSource = TravelAgency1Entities.GetContext().Страна.ToList();
        }

        private void BtnSave10_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentFlight.Тип_транспорта))
                errors.AppendLine("Укажите тип транспорта");
            if (string.IsNullOrWhiteSpace(_currentFlight.Пункт_отправления))
                errors.AppendLine("Укажите пункт отправления");
            if (string.IsNullOrWhiteSpace(_currentFlight.Пункт_назначения))
                errors.AppendLine("Выберите пункт назначения");
            if (_currentFlight.Дата_отправления == null)
                errors.AppendLine("Укажите дату отправления");
            if (_currentFlight.Время_в_пути_в_часах == null)
                errors.AppendLine("Укажите время в часах");
            if (_currentFlight.Количетво_мест == null)
                errors.AppendLine("Укажите кол-во мест");
            if (_currentFlight.Цена == null)
                errors.AppendLine("Укажите цену");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentFlight.ID == 0)
                TravelAgency1Entities.GetContext().Рейсы.Add(_currentFlight);

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

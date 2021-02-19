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
using Microsoft.Win32;
using System.IO;

namespace Travel_Agency
{
    /// <summary>
    /// Логика взаимодействия для EditHotels.xaml
    /// </summary>
    public partial class EditHotels : Page
    {
        private Отель _currentHotel = new Отель();
        public EditHotels(Отель selectedHotel)
        {
            if (selectedHotel != null)
                _currentHotel = selectedHotel;


            InitializeComponent();
            DataContext = _currentHotel;
        }

        private void BtnSave3_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentHotel.Изображение))
                errors.AppendLine("Укажите изображение");
            if (string.IsNullOrWhiteSpace(_currentHotel.Название))
                errors.AppendLine("Введите название отеля");
            if (_currentHotel.Количество_звезд < 1 || _currentHotel.Количество_звезд > 5)
                errors.AppendLine("Введите количество звезд от 1 до 5");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentHotel.ID == 0)
                TravelAgency1Entities.GetContext().Отель.Add(_currentHotel);

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

        private void BtnAddImage2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Title = "Select a picture",
                Filter = "All supported graphics | *.jpg;*.jpeg;*.png|" +
               "JPEG (*.jpg;*.jpeg) |*.jpg;*.jpeg|" +
               "Portable Network Graphics (*.png) |*.png"
            };
            if (op.ShowDialog() == true)
            {
                AddImage1.Source = new BitmapImage(new Uri(op.FileName));
            }

            var FileNameToSave = DateTime.Now.ToFileTime() + Path.GetExtension(op.FileName);
            var ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + FileNameToSave);
            TextBoxAdd.Text = ImagePath;
            TextBoxAdd.Focus();
            File.Copy(op.FileName, ImagePath);
        }
    }
}

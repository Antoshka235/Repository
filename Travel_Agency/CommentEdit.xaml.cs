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
    /// Логика взаимодействия для CommentEdit.xaml
    /// </summary>
    public partial class CommentEdit : Page
    {
        private Коментарий_о_отеле _currentComment = new Коментарий_о_отеле();
        public CommentEdit()
        {
            InitializeComponent();
            DataContext = _currentComment;
            ComboHotel.ItemsSource = TravelAgency1Entities.GetContext().Отель.ToList();
        }

        private void BtnSave9_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentComment.Отель))
                errors.AppendLine("Укажите отель!");
            if (string.IsNullOrWhiteSpace(_currentComment.Текст))
                errors.AppendLine("Введите ваш комментарий!");
            if (_currentComment.Дата_создания == null)
                errors.AppendLine("Укажите дату!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentComment.ID == 0)
                TravelAgency1Entities.GetContext().Коментарий_о_отеле.Add(_currentComment);

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

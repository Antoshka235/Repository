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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TravelAgency1Entities db = new TravelAgency1Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        //Создаем форму для входа в приложение
        private void BtnLogin2_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string pass = PassBox.Password;
            string client = "Клиент";
            string UserName;
            WindowClient windowClient = new WindowClient();
            MainWindow mainWindow = new MainWindow();
            StringBuilder errors = new StringBuilder();

            Пользователи authПользователи = null;
            using (TravelAgency1Entities db = new TravelAgency1Entities())
            {
                authПользователи = db.Пользователи.Where(b => b.Логин == login && b.Пароль == pass).FirstOrDefault();
            }

            if (login.Length < 5)
                errors.AppendLine("Длина логина не больше 5 символов");
            if (pass.Length < 6 || pass.Length > 18)
                errors.AppendLine("Длина пароля не меньше 5 смоволов");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else if (authПользователи != null && authПользователи.Role == client)
            {
                windowClient.Show();
                UserName = authПользователи.ФИО;
                Manager.MainFrame.Navigate(new GlavPage());
                LoginBox.Text = "";
                PassBox.Password = "";
                Close();
            }
            else
                MessageBox.Show("Не верный пароль или логин");

            if (authПользователи != null)

            {
                windowClient.Show();
                Close();
            }
           
        }

        private void BtnReg2_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginRegBox.Text;
            string pass = PassRegBox.Password;
            string role = "Клиент";
            string passTwo = PassRegBoxTwo.Password;

            StringBuilder errors = new StringBuilder();

            Пользователи regПользователи = null;
            using (TravelAgency1Entities db = new TravelAgency1Entities())
            {
                regПользователи = db.Пользователи.Where(b => b.Логин == login).FirstOrDefault();
            }

            if (regПользователи != null)
                errors.AppendLine("Данный логин уже существует, используйте другой!");
            if (login.Length < 5)
                errors.AppendLine("Длина логина не должна быть меньше 5 символов");
            if (pass.Length < 6 || pass.Length > 18)
                errors.AppendLine("Длина пароля не должна быть меньше 6 и больше 18 символов");
            if (pass != passTwo)
                errors.AppendLine("Пароли не совпадают!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                MessageBox.Show("Все хорошо!");
                Пользователи пользователи = new Пользователи(login, pass, role);

                db.Пользователи.Add(пользователи);
                db.SaveChanges();
            }
        }

        private void BtnScr3_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Btnlose3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}

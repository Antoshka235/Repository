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
    /// Логика взаимодействия для GlavPage.xaml
    /// </summary>
    public partial class GlavPage : Page
    {
        public GlavPage()
        {
            InitializeComponent();
        }

        private void BtnTours_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TourPage());
        }

        private void BtnExit4_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnHot_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new HotelsPage());
        }

        private void BtnKom_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CommentPage());
        }

        private void BtnFlight_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new FlightPage());
        }
    }
}

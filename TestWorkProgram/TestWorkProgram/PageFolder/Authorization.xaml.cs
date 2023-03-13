using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xamarin.Essentials;

namespace TestWorkProgram
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        User userValue;
        public Authorization()
        {
            InitializeComponent();
            DataContext = MainInfoClass.userVM;
        }

        private void ConnectToApi()
        {

            try
            {
                using (var client = new WebClient())
                {
                    var responze = client.DownloadString(string.Format("{0}/User/GetUsers", MainInfoClass.apiDBSource));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void emailNameGotFocus(object sender, RoutedEventArgs e)
        {
            if (loginName.Text == "Логин")
            {
                loginName.Text = "";
                loginName.Foreground = Brushes.Black;
                loginName.BorderBrush = Brushes.Black;
            }
        }

        private void emailNameLostFocus(object sender, RoutedEventArgs e)
        {
            if (loginName.Text == "")
            {
                loginName.Text = "Логин";
                loginName.Foreground = Brushes.Gray;
                loginName.BorderBrush = Brushes.Gray;
            }
        }

        private void passwordfieldGotFocus(object sender, RoutedEventArgs e)
        {
            passwordfield.Visibility = Visibility.Visible;
            passHelper.Visibility = Visibility.Hidden;
            passwordfield.Focus();
        }

        private void passwordfieldLostFocus(object sender, RoutedEventArgs e)
        {
            if (passwordfield.Password == "")
            {
                passwordfield.Visibility = Visibility.Hidden;
                passHelper.Visibility = Visibility.Visible;
            }
        }

        private void AuthorizationTapped(object sender, RoutedEventArgs e)
        {
            userValue = MainInfoClass.userVM.Users.Where(x=>x.Login == loginName.Text).FirstOrDefault();
            if (userValue != null)
            {
                if(userValue.Password == passwordfield.Password)
                {
                    MainInfoClass.userVM.SelectedUser = userValue;
                    NavigationService.Navigate(new ImageSend());
                }
                else
                {
                    PassWar.Visibility = Visibility.Visible;
                }
            }
            else
            {
                emailWar.Visibility = Visibility.Visible;
            }
        }
    }
}

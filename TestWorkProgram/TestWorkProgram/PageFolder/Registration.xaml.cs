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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWorkProgram
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
            DataContext = MainInfoClass.userVM;
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

        private void registrationTapped(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(loginName.Text) && String.IsNullOrEmpty(passwordfield.Password) && String.IsNullOrEmpty(userName.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else if (MainInfoClass.userVM.Users.Where(x => x.Login == loginName.Text).ToList().Count == 0)
            {
                User newUser = new User();
                newUser.Login = loginName.Text;
                newUser.Password = passwordfield.Password;
                newUser.Username = userName.Text;
                try
                {
                    using (var client = new WebClient())
                    {
                        client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                        string html = client.UploadString(string.Format("{0}/User/InsertUser", MainInfoClass.apiDBSource), JsonConvert.SerializeObject(newUser));
                    }
                    MainInfoClass.userVM.GetUserAsync();
                    MainInfoClass.userVM.SelectedUser = MainInfoClass.userVM.Users.Last();
                    NavigationService.Navigate(new ImageSend());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                emailWar.Visibility = Visibility.Visible;
            }
        }

        private void userNameGotFocus(object sender, RoutedEventArgs e)
        {
            if (userName.Text == "Имя")
            {
                userName.Text = "";
                userName.Foreground = Brushes.Black;
                userName.BorderBrush = Brushes.Black;
            }
        }

        private void userNameLostFocus(object sender, RoutedEventArgs e)
        {
            if (userName.Text == "")
            {
                userName.Text = "Имя";
                loginName.Foreground = Brushes.Gray;
                userName.BorderBrush = Brushes.Gray;
            }
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using TestWorkProgram.Command;
using static Xamarin.Essentials.Permissions;

namespace TestWorkProgram
{
    internal class UserVM : INotifyPropertyChanged
    {
        internal string selectedFileName = "";
        private User selectedUser;
        private List<User> contactUsers;
        private User chatUser;
        private ObservableCollection<User> users;
        private List<Image> imageTo;
        private List<Image> imageFrom;

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }
        public User ChatUser
        {
            get { return chatUser; }
            set
            {
                chatUser = value;
                GetImageAsync();
                OnPropertyChanged("ChatUser");
            }
        }

        public ObservableCollection<User> Users
        {
            get
            {
                return users;
            }
            set => users = value;
        }

        public List<User> ContactUsers
        {
            get
            {
                List<User> userNewList = new List<User> { SelectedUser };
                contactUsers = Users.Except(userNewList).ToList();
                return contactUsers;
            }
        }

        public List<Image> ImageTo
        {
            get
            {
                return imageTo;
            }
        }

        public List<Image> ImageFrom
        {
            get
            {
                return imageFrom;
            }
        }

        public UserVM()
        {
            GetUserAsync();
        }


        private SendCommand addCommand;
        public SendCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new SendCommand(obj =>
                  {
                      Image image = new Image();
                      image.ToId = MainInfoClass.userVM.ChatUser.Id;
                      image.FromId = MainInfoClass.userVM.SelectedUser.Id;
                      image.Buffer = System.IO.File.ReadAllBytes(selectedFileName);
                      image.To = MainInfoClass.userVM.ChatUser;
                      image.From = MainInfoClass.userVM.SelectedUser;
                      using (var client = new WebClient())
                      {
                          client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                          string html = client.UploadString("https://localhost:7113/api/Image/InsertImage", JsonConvert.SerializeObject(image));
                      }
                  }));
            }
        }


        internal async void GetUserAsync()
        {
            try
            {
                using (var client = new WebClient())
                {
                    var responze = await Task.Run(() => client.DownloadString(string.Format("{0}/User/GetUsers", MainInfoClass.apiDBSource)));
                    users = JsonConvert.DeserializeObject<ObservableCollection<User>>(responze);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal async void GetImageAsync()
        {
            try
            {
                List<Image> newListImage = new List<Image>();
                using (var client = new WebClient())
                {
                    var responze = await Task.Run(() => client.DownloadString(string.Format("{0}/Image/GetImages", MainInfoClass.apiDBSource)));
                    newListImage = JsonConvert.DeserializeObject<List<Image>>(responze);
                }
                imageTo = newListImage.Where(x => x.FromId == MainInfoClass.userVM.ChatUser.Id && x.ToId == SelectedUser.Id).ToList();
                imageFrom = newListImage.Where(x => x.ToId == MainInfoClass.userVM.ChatUser.Id && x.FromId == SelectedUser.Id).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для ImageSend.xaml
    /// </summary>
    public partial class ImageSend : Page
    {
      
        public ImageSend()
        {
            InitializeComponent();
            DataContext = MainInfoClass.userVM;
        }



        private void LoadImageClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = "c:\\";
            openDialog.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";

            if (openDialog.ShowDialog() == true)
            {
                FileInfo fileInfo = new FileInfo(openDialog.FileName);
                if (fileInfo.Length < 2621440)
                {
                    MainInfoClass.userVM.selectedFileName = openDialog.FileName;
                    nameFile.Text = openDialog.FileName.Split('\\').ToList().Last();
                    nameFile.Visibility = Visibility.Visible;
                    sendButton.Visibility = Visibility.Visible;
                    loadButton.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Размер файла превышает 2,5 мб");
                }
            }
        }


        private void sendClick(object sender, RoutedEventArgs e)
        {
            loadButton.Visibility = Visibility.Visible;
            sendButton.Visibility = Visibility.Hidden;
            nameFile.Visibility = Visibility.Hidden;
        }

        private void selectClient(object sender, MouseButtonEventArgs e)
        {
            chatGrid.Visibility = Visibility.Visible;
            loadButton.Visibility = Visibility.Visible;
            sendButton.Visibility = Visibility.Hidden;
            nameFile.Visibility = Visibility.Hidden;
        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainFrame.Navigate(new HotelsPage());
            MainFrame.Navigate(new TourPage());
            Manager.MainFrame = MainFrame;

            ImportTours();
        }
        private void ImportTours()
        {
            //если ставишь @ экранировать слеши не нужно
            var fileData = File.ReadAllLines(@"C:\Users\Daniil Tropin\Desktop\Tour.txt");
            //вместо констант лучше бы какой нибудь диалог пользователю показать
            //OpenFileDialog dialog = new OpenFileDialog()
            //{
            //    Title = "выберите файл для импорта"
            //};
            //if (dialog.ShowDialog()==true)
            //{
            //    //что-то делаем
            //}
            var images = Directory.GetFiles(@"C:\Users\Daniil Tropin\Desktop\Туры");

            foreach (var line in fileData)
            {
                var data = line.Split('\t');

                var tempTour = new Tour
                {
                    Name = data[0].Replace("\"", ""),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsActual = (data[4] == "0") ? false : true

                };

                foreach (var tourType in data[5].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = TourBaseEntities.GetContext().Type.ToList().FirstOrDefault(p => p.Name == tourType);

                    if (currentType != null)
                        tempTour.Type.Add(currentType);
                }

                try
                {
                    //ищет картинку, которая в имени содержит название тура? в папке таких нет, поэтому не может заполнить
                    string tourImagePath = images.FirstOrDefault(p => p.Contains(tempTour.Name));
                    //если нашли подходящую картинку, загружаем
                    if( string.IsNullOrEmpty(tourImagePath) == false)
                    {
                       tempTour.ImagePreview = File.ReadAllBytes(tourImagePath);
                    }
                    
                 
                }
                catch (Exception ex)
                {
                    //Почему консоль?
                    
                    Console.WriteLine(ex.Message);
                }

                //TourBaseEntities.GetContext().Tour.Add(tempTour);
                TourBaseEntities.GetContext().SaveChanges();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            { 
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}

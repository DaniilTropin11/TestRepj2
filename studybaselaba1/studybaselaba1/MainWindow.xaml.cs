using studybaselaba1.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace studybaselaba1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new BasePage());
            Admin.MainFrame = MainFrame;
            
          
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.GoBack();

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StudyContext studyContext = new StudyContext();
            if (studyContext.Groups.Any() == false) //бд пустая 
            {
                var Group = new Group()
                {
                    NumberGroup = "PIB-11",
                    EducationForm = "очная",
 
                };
                studyContext.Groups.Add (Group);
                studyContext.SaveChanges();

            }
        }
    }
}

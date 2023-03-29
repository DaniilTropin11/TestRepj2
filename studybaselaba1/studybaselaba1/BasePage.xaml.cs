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

namespace studybaselaba1
{
    /// <summary>
    /// Логика взаимодействия для BasePage.xaml
    /// </summary>
    public partial class BasePage : Page
    {
        public BasePage()
        {
            InitializeComponent();
            
            DGridBase.ItemsSource = StudyContext.GetContext().Groups.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGridBase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

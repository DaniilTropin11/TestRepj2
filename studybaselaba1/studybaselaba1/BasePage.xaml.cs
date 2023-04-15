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

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Admin.MainFrame.Navigate(new AddEditPage(null));
        //}

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Ocenka ocenka = DGridBase.DataContext as Ocenka;
            if (ocenka != null)
            {
                MessageBox.Show("Ничего не выбрано ! ");
                return;
            }
        }

        private void DGridBase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInform_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.Navigate(new Information());
        }
    }
}

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
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Page
    {
        public Information()
        {
            InitializeComponent();
            DGridBase.ItemsSource = StudyContext.GetContext().Ocenkas.ToList();
        
        }

        
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (this._selectedOcenka == null)
            {
                MessageBox.Show("Ничего не выбрано!");
                return;
            }
            else
            {
                var userChoice = MessageBox.Show($"Вы уверены, что хотите удалить группу {_selectedOcenka.Group}?",
                    "Подтвердите удаление", MessageBoxButton.YesNo);
                if (userChoice == MessageBoxResult.Yes)
                {

                    StudyContext.GetContext().Ocenkas.Remove(_selectedOcenka);
                    StudyContext.GetContext().SaveChanges();
                    DGridBase.ItemsSource = StudyContext.GetContext().Ocenkas.ToArray();
                   
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
           
            Admin.MainFrame.Navigate(new AddEditPage(_selectedOcenka));

        }

        Ocenka _selectedOcenka; 
        private void DGridBase_SelectionChanged(object sender, SelectionChangedEventArgs e)// DG это свойство используется только при выделении 
        {
            _selectedOcenka = DGridBase.SelectedItem as Ocenka;
        }
    }
}

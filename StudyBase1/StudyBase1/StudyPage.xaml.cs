using Microsoft.EntityFrameworkCore;
using StudyBase1.models;
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

namespace StudyBase1
{
    /// <summary>
    /// Логика взаимодействия для StudyPage.xaml
    /// </summary>
    public partial class StudyPage : Page
    {
        public List<Chacha> Sdacha { get; set; }

        public StudyPage()
        {
            InitializeComponent();

            Sdacha = App.DB.Chachas.Include(s => s.Discipline).Include(a => a.Student).Include(b => b.Ocenka).ToList();
            DGridStudyBase.ItemsSource = Sdacha;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Admin.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedGroup = DGridStudyBase.SelectedItem as Chacha;
            if (selectedGroup != null)
            {
                App.DB.Chachas.Remove(selectedGroup);
                App.DB.SaveChanges();
                Sdacha = App.DB.Chachas.ToList();


               MessageBox.Show($"Выбранный студент с id {selectedGroup.Id} и название {selectedGroup.Student.Name}");
            }

            else
            {
                MessageBox.Show("Ничего не выбрано");
            }

        }

        private void DGridStudyBase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }



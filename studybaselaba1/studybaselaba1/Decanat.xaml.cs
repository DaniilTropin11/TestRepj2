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
    /// Логика взаимодействия для Decanat.xaml
    /// </summary>
    public partial class Decanat : Page
    {

        Group _group;

        public static List<Fakultet> Fakultets 
        
        { 
            get; 
            set; 
        }
       

        public Decanat()
        {
            Fakultets = StudyContext.GetContext().Faculties.ToList();
            InitializeComponent();
            StudyContext.GetContext().Groups.Load();
            GroupUniversity.ItemsSource = StudyContext.GetContext().Groups.Local;

        }

        //private void BtnDelete2_Click(object sender, RoutedEventArgs e)
        //{
        //    if (this._group == null)
        //    {
        //        MessageBox.Show("Ничего не выбрано!");
        //        return;
        //    }
        //    else
        //    {
        //        var UserCh = MessageBox.Show($"Вы уверены, что хотите удалить группу {_group.NumberGroup}?",
        //              "Подтвердите удаление", MessageBoxButton.YesNo);
        //        if (UserCh == MessageBoxResult.Yes)

        //        {

        //            StudyContext.GetContext().Groups.Remove(_group);
        //            StudyContext.GetContext().SaveChanges();
        //            GroupUniversity.ItemsSource = StudyContext.GetContext().Groups.ToArray();
        //        }
        //    }
        //}


        private void GroupUniversity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _group = GroupUniversity.SelectedItem as Group;
        }


       

        private void BtnDelete2_Click_1(object sender, RoutedEventArgs e)
        {
            if (this._group == null)
            {
                MessageBox.Show("Ничего не выбрано!");
                return;
            }
            else
            {
                var UserCh = MessageBox.Show($"Вы уверены, что хотите удалить группу {_group.NumberGroup}?",
                      "Подтвердите удаление", MessageBoxButton.YesNo);
                if (UserCh == MessageBoxResult.Yes)

                {

                    StudyContext.GetContext().Groups.Remove(_group);
                    StudyContext.GetContext().SaveChanges();
                    GroupUniversity.ItemsSource = StudyContext.GetContext().Groups.ToArray();

                }
            }

        }

        private void BtnEdit2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveGroup_Click(object sender, RoutedEventArgs e)
        {
            var group = GroupUniversity.SelectedItem as Group;
            
                 StringBuilder errors = new StringBuilder();


            if ( group.NumberGroup== null)
                {
                    errors.AppendLine("Введите название группы");
                    MessageBox.Show("Введите название группы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            if (string.IsNullOrWhiteSpace(group.NumberGroup))
            {
                errors.AppendLine("Введите название группы");
                MessageBox.Show("Введите название группы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

                if (group.Fakultet == null)
                {
                    errors.AppendLine("Выберите факультет");
                    MessageBox.Show("Выберите факультет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            if (group.EducationForm == null)
            {
                errors.AppendLine("Введите форму обучения группы");
                MessageBox.Show("Введите фомру обучения группы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

                if (errors.Length == 0)
                {
                    StudyContext.GetContext().Groups.Add(_group);
                    StudyContext.GetContext().SaveChanges();

                    //this.NavigationService.GoBack();
                
                //нет ошибок - возвращаемся к пред. странице
                                                    //this.DialogResult = true;
                                                    //Close();
                                                    //MessageBox.Show("Данные успешно сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        
    }
}



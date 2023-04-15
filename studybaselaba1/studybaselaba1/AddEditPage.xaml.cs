using studybaselaba1.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Ocenka _ocenka;
        //public AddEditPage(Ocenka ocenka)
        //{
        //    InitializeComponent();
        //    if (ocenka != null)
        //        Ocenka = ocenka; 


            
        //}

        public AddEditPage(Ocenka ocenka)
        {
            InitializeComponent();

            if (ocenka != null)
            {
                _ocenka = ocenka;
            }
            else
            {
                _ocenka = new Ocenka();
            }
            DataContext = _ocenka;
            ComboNameGroup.ItemsSource = StudyContext.GetContext().Groups.ToList();
            ComboNameDiscipline.ItemsSource = StudyContext.GetContext().Disciplines.ToList();

        }






        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
           
            StringBuilder errors = new StringBuilder();
            

            if (ComboNameDiscipline.SelectedItem == null)
            {
                errors.AppendLine("Выберите дисциплину");
                MessageBox.Show("Выберите дисциплину", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            if (ComboNameGroup.SelectedItem == null)
            {
                errors.AppendLine("Выберите группу");
                MessageBox.Show("Выберите группу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (errors.Length == 0)
            {
                StudyContext.GetContext().Ocenkas.Add(_ocenka);
                StudyContext.GetContext().SaveChanges();

                this.NavigationService.GoBack();//нет ошибок - возвращаемся к пред. странице
                //this.DialogResult = true;
                //Close();
                //MessageBox.Show("Данные успешно сохранены", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Grid_Error(object sender, ValidationErrorEventArgs e)
        {
           
            {
                if (e.Action == ValidationErrorEventAction.Added)
                {
                    (e.Source as TextBox).ToolTip = e.Error.ErrorContent.ToString();
                }
                else if (!((BindingExpressionBase)e.Error.BindingInError).HasError)
                {
                    (e.Source as TextBox).ToolTip = null;
                    return;
                }
                
            }
        }
    }
}

using studybaselaba1.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
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
        Ocenka ocenka;
        public AddEditPage()
        {
            InitializeComponent();
            ocenka = new Ocenka();
            DataContext = ocenka;
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
            
            //string pattern5 = "^[0-9]+$|^-$";
            //bool isMatch = Regex.IsMatch(Text5.Text, pattern5);

            //if (!Regex.IsMatch(Text5.Text, pattern5))
            //{
            //    errors.AppendLine("Строка содержит некорректные символы");
            //    MessageBox.Show("Строка содержит некорректные символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}


            //string pattern4 = "^[0-9]+$|^-$";
            //bool isMatch2 = Regex.IsMatch(Text4.Text, pattern4);

            //if (!Regex.IsMatch(Text4.Text, pattern4))
            //{
            //    errors.AppendLine("Строка содержит некорректные символы");
            //    MessageBox.Show("Строка содержит некорректные символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            //string pattern3 = "^[0-9]+$|^-$";
            //bool isMatch3 = Regex.IsMatch(Text3.Text, pattern3);

            //if (!Regex.IsMatch(Text3.Text, pattern3))
            //{
            //    errors.AppendLine("Строка содержит некорректные символы");
            //    MessageBox.Show("Строка содержит некорректные символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

            //string pattern2 = "^[0-9]+$|^-$";
            //bool isMatch4 = Regex.IsMatch(Text2.Text, pattern2);

            //if (!Regex.IsMatch(Text2.Text, pattern2))
            //{
            //    errors.AppendLine("Строка содержит некорректные символы");
            //    MessageBox.Show("Строка содержит некорректные символы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

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
                }
            }
        }
    }
}

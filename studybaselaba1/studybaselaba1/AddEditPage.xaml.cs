using studybaselaba1.DataModel;
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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Group _currentGroup = new Group();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentGroup;
            ComboNameGroup.ItemsSource = StudyContext.GetContext().Groups.ToList();
            ComboNameDiscipline.ItemsSource = StudyContext.GetContext().Disciplines.ToList();
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentGroup.NumberGroup))
                errors.AppendLine("Выберите название группы");
            if (string.IsNullOrWhiteSpace(_currentGroup.Disciplines))
                errors.AppendLine("Выюерите дисциплину");
        }
    }
}

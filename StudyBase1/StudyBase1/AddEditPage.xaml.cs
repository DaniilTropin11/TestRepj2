using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Student _newStudent = new Student();
        private Discipline _predmet = new Discipline();
        public List<Ocenki> ocenkis { get; set; }
        public List<Chacha> cdacha { get; set; }
        
       
        public AddEditPage()
        {
            InitializeComponent();
            
            DataContext = _newStudent;
            //ComboOcenka.ItemsSource = StudyBaseContext.
            ocenkis = App.DB.Ocenkis.ToList();
            ComboOcenka.ItemsSource=ocenkis;



        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            StringBuilder errors2 = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_newStudent.Name))
                errors.AppendLine("Введите ФИО студента");
            if (string.IsNullOrWhiteSpace(_predmet.Наименование))
                errors2.AppendLine("Введите предмет");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                MessageBox.Show(errors2.ToString());
                return;
            }
            //StringBuilder errors2 = new StringBuilder();
            //if (string.IsNullOrWhiteSpace(_predmet.Наименование))
            //    errors2.AppendLine("Введите предмет");
            //if (errors2.Length > 0)
            //{
            //MessageBox.Show(errors2.ToString());
            //return;
            //}
            //if (_newStudent.Id == 0) ;

        }
    }
}

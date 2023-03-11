using StudyBaseConsole.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudyBaseConsole
{
     class Program
    {
        static void Main(string[] args)
        {
            using (StudyContext context = new StudyContext())
            {
                Student student = new Student() ;
                student.Name = "Иван";
                student.Surname = "Прокопов";

               

                var students =  new Student[] { };
                var result = context.Students.Where ( s => s.Name == "Иван");
                
                context.Students.Add(student);
                context.SaveChanges();
                foreach(var s in result)
                {
                    Console.WriteLine(s.Name);
                }
                Console.WriteLine(result);




            }
            
        }
    }
}



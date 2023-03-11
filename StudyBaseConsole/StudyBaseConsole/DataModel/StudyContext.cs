using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace StudyBaseConsole.DataModel
{
    public class StudyContext : DbContext
    {
       
        public StudyContext()
            : base("name=StudyContext")
        {
        }
        public DbSet<Student> Students { get; set; }

    }
   

   
}
using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class Student
    {
        public Student()
        {
            Chachas = new HashSet<Chacha>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? IdGroup { get; set; }

        public virtual NumberGroup? IdGroupNavigation { get; set; }
        public virtual ICollection<Chacha> Chachas { get; set; }
    }
}

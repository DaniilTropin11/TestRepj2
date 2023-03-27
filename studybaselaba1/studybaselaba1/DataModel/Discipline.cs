using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace studybaselaba1
{
      public class Discipline
    {
        public int IdDiscipline { get; set; }
        public string NameDiscipline { get; set; }
        public DateTime ExamDate { get; set; }
        public int Count5 { get; set; }
        public int Count4{ get; set; }
        public int Count3 { get; set; }
        public int Count2 { get; set; }

        public int IsAbsent { get; set; }
        public virtual ICollection <Group> Groups { get; set; }


    }
}

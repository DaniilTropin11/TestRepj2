using studybaselaba1.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1
{
    public class Ocenka
    {
        public int OcenkaId { get; set; }
        public DateTime ExamDate { get; set; }
        public int Count5 { get; set; }
        public int Count4 { get; set; }
        public int Count3 { get; set; }
        public int Count2 { get; set; }

        public int IsAbsent { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }
    }
}

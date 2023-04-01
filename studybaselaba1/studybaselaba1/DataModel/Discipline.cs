using studybaselaba1.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1
{
      public class Discipline
    {
        public int DisciplineId { get; set; }
        public string NameDiscipline { get; set; }
       
        public virtual ICollection <Group> Groups { get; set; }
        public ICollection<Ocenka> Ocenkas { get; set; }


    }
}

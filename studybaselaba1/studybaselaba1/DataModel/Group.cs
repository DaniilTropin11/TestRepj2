using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1.DataModel
{
     public class Group
    {
        public int GroupId { get; set; }
        public string NumberGroup { get; set; }
        public string EducationForm { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }



    }
}

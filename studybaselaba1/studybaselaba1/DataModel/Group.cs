using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1.DataModel
{
     public class Group
    {
        public int IdGroup { get; set; }
        public string NameGroup { get; set; }
        public FormaObychenia FormaObychenia { get; set; }
        public Fakultet Fakultet { get; set; }

       
    }
}

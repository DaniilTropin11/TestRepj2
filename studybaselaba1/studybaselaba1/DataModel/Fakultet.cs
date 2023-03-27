using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1.DataModel
{
    public  class Fakultet
    {
         public int IdFakultet { get; set; }
        public string Name { get; set; }
        
        public ICollection<Group> Groups { get; set; }
    }
}

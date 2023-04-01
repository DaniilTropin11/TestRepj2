using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1.DataModel
{
    public  class Fakultet
    {
         public int FakultetId { get; set; }
        public string NameFakultet { get; set; }
        
        
        public ICollection<Group> Groups { get; set; }
        public Fakultet()
        {
            Groups = new List<Group>();
        }
    }
}

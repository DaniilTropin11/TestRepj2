using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studybaselaba1.DataModel
{
    public class Cdacha
    {
        public int IdCdacha { get; set; }
        public DateTime date { get; set; }
        public Group Group { get; set; }
        public Fakultet Fakultet { get; set; }
        public FormaObychenia FormaObychenia { get; set; }  
        public Discipline Discipline { get; set; }
        public Ocenki Ocenki { get; set; }

    }
}

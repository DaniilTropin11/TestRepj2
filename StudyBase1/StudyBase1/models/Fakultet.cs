using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class Fakultet
    {
        public Fakultet()
        {
            NumberGroups = new HashSet<NumberGroup>();
        }

        public int Id { get; set; }
        public string? НаименованиеФакультета { get; set; }

        public virtual ICollection<NumberGroup> NumberGroups { get; set; }
    }
}

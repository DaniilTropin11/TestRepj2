using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class FormaObychenium
    {
        public FormaObychenium()
        {
            NumberGroups = new HashSet<NumberGroup>();
        }

        public int Id { get; set; }
        public string? ФормаОбучения { get; set; }

        public virtual ICollection<NumberGroup> NumberGroups { get; set; }
    }
}

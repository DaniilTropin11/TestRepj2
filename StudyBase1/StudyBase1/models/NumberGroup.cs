using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class NumberGroup
    {
        public NumberGroup()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string? НаименованиеГруппы { get; set; }
        public int? IdFormaObychenia { get; set; }
        public int? IdFakultet { get; set; }

        public virtual Fakultet? IdFakultetNavigation { get; set; }
        public virtual FormaObychenium? IdFormaObycheniaNavigation { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

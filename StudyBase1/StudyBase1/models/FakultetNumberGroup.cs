using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class FakultetNumberGroup
    {
        public int? Ngid { get; set; }
        public int? Fakultetid { get; set; }
        public int? Foid { get; set; }
        public int? Ocenkiid { get; set; }
        public int? Disciplineid { get; set; }

        public virtual Discipline? Discipline { get; set; }
        public virtual Fakultet? Fakultet { get; set; }
        public virtual FormaObychenium? Fo { get; set; }
        public virtual NumberGroup? Ng { get; set; }
        public virtual Ocenki? Ocenki { get; set; }
    }
}

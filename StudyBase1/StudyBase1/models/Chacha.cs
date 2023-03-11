using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class Chacha
    {
        public int Id { get; set; }
        public int? DisciplineId { get; set; }
        public DateTime? DataChacha { get; set; }
        public int? OcenkaId { get; set; }
        public int? StudentId { get; set; }

        public virtual Discipline? Discipline { get; set; }
        public virtual Ocenki? Ocenka { get; set; }
        public virtual Student? Student { get; set; }
    }
}

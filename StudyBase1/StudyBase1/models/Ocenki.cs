using System;
using System.Collections.Generic;

namespace StudyBase1.models
{
    public partial class Ocenki
    {
        public Ocenki()
        {
            Chachas = new HashSet<Chacha>();
        }

        public int Id { get; set; }
        public string? Название { get; set; }
        public int? Балл { get; set; }

        public virtual ICollection<Chacha> Chachas { get; set; }
    }
}

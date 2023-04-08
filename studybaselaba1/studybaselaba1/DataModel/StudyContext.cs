using studybaselaba1.DataModel;
using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;

namespace studybaselaba1
{
    public class StudyContext : DbContext
    {
        private static StudyContext _context;
        public static StudyContext Instance { get; set; }

        public StudyContext()
            : base("name=StudyContext")
        {
        }

        public static StudyContext GetContext()
        {
            if (_context == null)
                _context = new StudyContext();
            return _context;
        }
        public DbSet <Fakultet> Faculties { get; set; }
        public DbSet <Group> Groups { get; set; }
        public DbSet <Discipline> Disciplines { get; set; }
        public DbSet<Ocenka> Ocenkas { get; set; }

       
    }

    
}
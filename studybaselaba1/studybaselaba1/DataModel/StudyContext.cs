using studybaselaba1.DataModel;
using System;
using System.Data.Entity;
using System.Linq;

namespace studybaselaba1
{
    public class StudyContext : DbContext
    {
        private static StudyContext _context;
       
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
        public DbSet<Group> Groups { get; set; }
        public DbSet<FormaObychenia> FormaObychenias { get; set; }
        public DbSet<Fakultet> Fakultets { get; set; }
        public DbSet <Discipline> Disciplines { get; set; }
        public DbSet<Ocenki> Ocenkis { get; set; }
        public DbSet<Cdacha> Cdachas { get; set; }
  
       
    }

    
}
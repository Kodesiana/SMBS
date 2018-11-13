using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBS.DAL
{
    public class SmbsContext : DbContext
    {
        public DbSet<Analysis> Analysis { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Student> Students { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

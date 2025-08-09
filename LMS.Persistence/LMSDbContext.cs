using LMS.ApplicationCore.Entities.Common;
using LMS.ApplicationCore.Entities.Education;
using LMS.ApplicationCore.Entities.Finance;
using LMS.ApplicationCore.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace LMS.Persistence
{
   public class LMSDbContext : DbContext
    {
        public LMSDbContext(DbContextOptions<LMSDbContext>options):base(options)
        {
            
        }

        #region Identity
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        #endregion

        #region Education
        public DbSet<Level> Levels { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<TermCourse> TermCourses { get; set; }
        public DbSet<TermCourseType> TermCourseTypes { get; set; }
        #endregion
      
        #region Finance
        public DbSet<PaymentTuition> PaymentTuitions { get; set; }

        #endregion

        public override int SaveChanges()
        {
            SetCreateUpdateDate();
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetCreateUpdateDate();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void SetCreateUpdateDate()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreateDate = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.LastUpdate = DateTime.UtcNow;
                }
            }
        }
    }
}

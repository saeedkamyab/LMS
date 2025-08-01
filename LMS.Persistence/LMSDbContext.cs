using LMS.ApplicationCore.Entities.Education;
using Microsoft.EntityFrameworkCore;

namespace LMS.Persistence
{
   public class LMSDbContext : DbContext
    {
        public LMSDbContext(DbContextOptions<LMSDbContext>options):base(options)
        {
            
        }
        public DbSet<Level> Levels { get; set; }


       
    }
}

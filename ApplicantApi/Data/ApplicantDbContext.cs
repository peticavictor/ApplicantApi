using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApplicantApi.Data
{
    public class ApplicantDbContext : IdentityDbContext
    {
        public ApplicantDbContext(DbContextOptions<ApplicantDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Applicant> Applicant { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

         => optionsBuilder.UseNpgsql("Host=tyke.db.elephantsql.com;Port=5432;Database=btfayonf;Username=btfayonf;Password=YGRztec9Vh2uqHATDho4F7gia4FHXKVL;");
    }
}

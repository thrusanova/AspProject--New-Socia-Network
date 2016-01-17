
namespace AspNetProject.Data
{
    using System.Data.Entity;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;

    public class ApplicationDbContext : IdentityDbContext<User>,IAppContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Certification>Certifications { get; set; }

        public IDbSet<Discussion>Discussions { get; set; }

        public IDbSet<Experience>Experiences { get; set; }

        public IDbSet<Group>Groups { get; set; }

        public IDbSet<UserLanguage> Languages { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<Skill>Skills { get; set; }

        public IDbSet<Endorcement>Endorcements { get; set; }

        public IDbSet<AdministrationLog>AdministationLogs { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endorcement>().HasRequired(x => x.UserSkill).WithMany(x => x.Endorcements).WillCascadeOnDelete(false);
            modelBuilder.Entity<Experience>().HasRequired(x => x.User).WithMany(x => x.Experieces).WillCascadeOnDelete(false);
            modelBuilder.Entity<Group>().HasRequired(x => x.Owner).WithOptional().WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }
    }
}

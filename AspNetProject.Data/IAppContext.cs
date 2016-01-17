
namespace AspNetProject.Data
{
    using AspNetProject.Models;
    using System.Data.Entity;

    public interface IAppContext
    {
         IDbSet<Certification> Certifications { get; set; }

         IDbSet<Discussion> Discussions { get; set; }

         IDbSet<Experience> Experiences { get; set; }

         IDbSet<Group> Groups { get; set; }

         IDbSet<UserLanguage> Languages { get; set; }

         IDbSet<Project> Projects { get; set; }

         IDbSet<Skill> Skills { get; set; }

         IDbSet<Endorcement> Endorcements { get; set; }

         IDbSet<AdministrationLog> AdministationLogs { get; set; }

        int SaveChanges();
    }
}

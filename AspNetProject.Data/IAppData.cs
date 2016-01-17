

//unit of work
namespace AspNetProject.Data
{
    using AspNetProject.Data.Repositories;
    using AspNetProject.Models;

    public  interface IAppData
    {
        IRepository<User> Users { get; }

       IRepository<Certification> Certifications { get; }

        IRepository<Discussion> Discussions { get; }

        IRepository<Experience> Experiences { get; }

        IRepository<Group> Groups { get; }

        IRepository<UserLanguage> Languages { get; }

        IRepository<Project> Projects { get; }

        IRepository<Skill> Skills { get; }

        IRepository<Endorcement> Endorcements { get; }

        IRepository<AdministrationLog> AdministationLogs { get; }

        int SaveChanges();
    }
}

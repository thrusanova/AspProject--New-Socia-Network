
namespace AspNetProject.Models
{
    using System.Collections.Generic;

    public class Skill
    {
        private ICollection<UserSkill> users;

        public Skill()
        {
            this.users = new HashSet<UserSkill>();
        }

        public int Id { get; set; }

        public  string Name { get; set; }

        public virtual ICollection<UserSkill>UserSkills
        {
            get { return this.users; }
            set { this.users = value; }
        }

    }
}
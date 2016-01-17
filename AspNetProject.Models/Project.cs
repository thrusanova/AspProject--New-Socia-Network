
namespace AspNetProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Project
    {
        private ICollection<User> teamMembers;

        public Project()
        {
            this.teamMembers = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Url { get; set; }

        public string OcupationExperienceId { get; set; }

        public virtual Experience OcupationExperience { get; set; }

        public virtual ICollection<User>TeamMembers
        {
            get { return this.teamMembers; }
            set { this.teamMembers = value; }
        }

             
    }
}
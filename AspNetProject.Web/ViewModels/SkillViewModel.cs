
namespace AspNetProject.Web.ViewModels
{
    using AspNetProject.Models;
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Collections.Generic;

    public class SkillViewModel
    {
        public static Expression<Func<UserSkill,SkillViewModel>> ViewModel
        {
            get
            {
                return x => new SkillViewModel
                {
                    Id=x.Id,
                    Name=x.Skill.Name,
                    EndorsementsCount=x.Endorcements.Count,
                    Endorsers=x.Endorcements.Select(e=>e.User.UserName)

                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int EndorsementsCount { get; set; }

        public IEnumerable<string> Endorsers { get;  set; }
    }
}
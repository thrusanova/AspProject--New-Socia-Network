
namespace AspNetProject.Web.ViewModels
{
    using AspNetProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class UserViewModel
    {
        public static Expression<Func<User, UserViewModel>> ViewModel
        {
            get
            {
                return m => new UserViewModel
                {
                    Id = m.Id,
                    UserName = m.UserName,
                    Email = m.Email,
                    Summary = m.Summary,
                    ContactInfo = m.ContactInfo,
                    FullName = m.FullName,
                    AvatarUrl = m.AvatarUrl,
                    Certifications = m.Certifications.AsQueryable().Select(CertificationViewModel.ViewModel),
                    Skills=m.Skills.AsQueryable().Select(SkillViewModel.ViewModel)
                };
            }
        }
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Име")]
        public string FullName { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public string Summary { get; set; }

        public string AvatarUrl { get; set; }

        public  IEnumerable<CertificationViewModel> Certifications { get; set; }

        public IEnumerable<SkillViewModel>Skills { get; set; }
      

    }
}

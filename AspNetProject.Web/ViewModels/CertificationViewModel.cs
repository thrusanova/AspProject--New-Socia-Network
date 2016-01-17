

namespace AspNetProject.Web.ViewModels
{
    using System;
    using AspNetProject.Models;
    using System.Linq.Expressions;

    public class CertificationViewModel
    {
        public static Expression<Func<Certification, CertificationViewModel>> ViewModel
        {
            get
            {
                return m => new CertificationViewModel
                {
                    Id=m.Id,
                    Name=m.Name,
                    Url=m.Url
                };
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string lisenceNumber { get; set; }

        public string Url { get; set; }

        public DateTime TakenDate { get; set; }

        public DateTime ExpiredDate { get; set; }

     
    }
}
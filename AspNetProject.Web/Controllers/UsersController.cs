
namespace AspNetProject.Web.Controllers
{
    using AspNetProject.Data;
    using ViewModels;
    using System.Web.Mvc;
    using System.Linq;
    using System.Data.Entity;

    [Authorize]
    public class UsersController : BaseController
    {
        public UsersController(IAppData data) : base(data)
        {
        }
        public ActionResult Index(string username)
        {
            // var user = this.Data.Users.All().FirstOrDefault(x => x.UserName == username);
            var user = this.Data.Users
                 .All()
                 .Include(x=>x.Certifications)
                 .Include(x => x.Skills)
                 .Include("Skills.Skill")
                 .Include("Skills.Skill.User")
                 .Where(x => x.UserName == username)
                 .Select(UserViewModel.ViewModel)
                 .FirstOrDefault();

            if (user == null)
            {
                return this.HttpNotFound("User does not exit!");
            }
       //   var userViewModel =  UserViewModel.FromModel(user);
          
            return this.View(user);
        }
    }
}
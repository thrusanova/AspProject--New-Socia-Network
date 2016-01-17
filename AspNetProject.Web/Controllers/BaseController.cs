
namespace AspNetProject.Web.Controllers
{
    using System.Web.Mvc;
    using Data;
    using AspNetProject.Models;
    using System;
    using System.Web.Routing;
    using System.Linq;

    public abstract class BaseController : Controller
    {
        private IAppData data;
        private User userProfile;

        protected BaseController(IAppData data)
        {
            this.Data = data;
        }

        protected BaseController(IAppData data, User userProfile)
            :this(data)
        {
            this.UserProfile = userProfile;
        }

        protected IAppData Data { get; private set; }

        protected User UserProfile { get; private set; }

       protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
       {
         if (requestContext.HttpContext.User.Identity.IsAuthenticated)
          {
                var username = requestContext.HttpContext.User.Identity.Name;
              var user = this.Data.Users.All().FirstOrDefault(x=>x.UserName==username);
              this.UserProfile = user;
         }
          return base.BeginExecute(requestContext, callback, state);
       }
    }
}
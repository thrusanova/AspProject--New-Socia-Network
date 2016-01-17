using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetProject.Web.Startup))]
namespace AspNetProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

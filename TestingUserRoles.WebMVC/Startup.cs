using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingUserRoles.WebMVC.Startup))]
namespace TestingUserRoles.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

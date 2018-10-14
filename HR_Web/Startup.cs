using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HR_Web.Startup))]
namespace HR_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

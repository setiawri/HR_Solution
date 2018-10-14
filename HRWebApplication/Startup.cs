using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRWebApplication.Startup))]
namespace HRWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

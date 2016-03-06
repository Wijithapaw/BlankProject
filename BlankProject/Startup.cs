using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof($ext_safeprojectname$.Startup))]
namespace $ext_safeprojectname$
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

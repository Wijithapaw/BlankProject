using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlankProject.Startup))]
namespace BlankProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

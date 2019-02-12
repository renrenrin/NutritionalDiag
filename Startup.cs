using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NutsaProject.Startup))]
namespace NutsaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

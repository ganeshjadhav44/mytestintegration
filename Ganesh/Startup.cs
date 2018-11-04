using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ganesh.Startup))]
namespace Ganesh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

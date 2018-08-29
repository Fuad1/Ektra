using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ektra.Startup))]
namespace Ektra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

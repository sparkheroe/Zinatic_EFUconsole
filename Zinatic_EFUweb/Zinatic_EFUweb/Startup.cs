using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zinatic_EFUweb.Startup))]
namespace Zinatic_EFUweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

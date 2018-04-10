using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavidsCatshift.Startup))]
namespace DavidsCatshift
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

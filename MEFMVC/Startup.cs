using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MEFMVC.Startup))]
namespace MEFMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

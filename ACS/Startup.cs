using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACS.Website.Startup))]
namespace ACS.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

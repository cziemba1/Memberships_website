using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membership_website.Startup))]
namespace Membership_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

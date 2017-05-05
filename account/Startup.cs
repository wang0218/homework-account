using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(account.Startup))]
namespace account
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kickoff.Startup))]
namespace kickoff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

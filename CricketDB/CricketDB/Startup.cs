using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CricketDB.Startup))]
namespace CricketDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

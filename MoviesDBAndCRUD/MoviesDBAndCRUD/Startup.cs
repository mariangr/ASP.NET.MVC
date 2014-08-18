using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesDBAndCRUD.Startup))]
namespace MoviesDBAndCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

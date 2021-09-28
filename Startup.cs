using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoeMovies.Startup))]
namespace JoeMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

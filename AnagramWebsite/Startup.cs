using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnagramWebsite.Startup))]
namespace AnagramWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

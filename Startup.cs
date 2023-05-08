using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPortafolio1173901.Startup))]
namespace EPortafolio1173901
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

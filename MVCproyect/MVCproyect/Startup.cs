using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCproyect.Startup))]
namespace MVCproyect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

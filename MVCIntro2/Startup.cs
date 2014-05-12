using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCIntro2.Startup))]
namespace MVCIntro2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

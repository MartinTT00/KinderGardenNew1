using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KinderGardenNew1.Startup))]
namespace KinderGardenNew1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(businessSoftwareMDSoft.Startup))]
namespace businessSoftwareMDSoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

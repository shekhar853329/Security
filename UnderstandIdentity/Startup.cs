using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnderstandIdentity.Startup))]
namespace UnderstandIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

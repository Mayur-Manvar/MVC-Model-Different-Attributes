using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDifferentAttributes.Startup))]
namespace MVCDifferentAttributes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

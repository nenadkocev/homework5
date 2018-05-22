using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(d5.Startup))]
namespace d5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

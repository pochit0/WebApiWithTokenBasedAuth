using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TokenBasedAuth.Api.Startup))]

namespace TokenBasedAuth.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
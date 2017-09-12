using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCExceptions.Startup))]
namespace MVCExceptions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF6Sample.Startup))]
namespace EF6Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

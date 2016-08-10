using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(continiousapp.Startup))]
namespace continiousapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_samostojno.Startup))]
namespace Lab3_samostojno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

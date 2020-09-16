using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HafeezCRUD.Startup))]
namespace HafeezCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

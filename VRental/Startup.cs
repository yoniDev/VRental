using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VRental.Startup))]
namespace VRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

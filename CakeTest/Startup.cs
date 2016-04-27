using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CakeTest.Startup))]
namespace CakeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

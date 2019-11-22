using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PVO.Startup))]
namespace PVO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoUIMVC.Startup))]
namespace KendoUIMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

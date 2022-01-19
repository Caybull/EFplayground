using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFExampleWithContextInModels.Startup))]
namespace EFExampleWithContextInModels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

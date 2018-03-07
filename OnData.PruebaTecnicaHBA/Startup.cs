using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnData.PruebaTecnicaHBA.Startup))]
namespace OnData.PruebaTecnicaHBA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

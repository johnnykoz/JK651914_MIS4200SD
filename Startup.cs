using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JK651914_MIS4200SD.Startup))]
namespace JK651914_MIS4200SD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

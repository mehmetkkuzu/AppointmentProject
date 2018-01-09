using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaserGroup.Automotive.UI.Startup))]
namespace CaserGroup.Automotive.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}

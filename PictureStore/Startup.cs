using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PictureStore.Startup))]
namespace PictureStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

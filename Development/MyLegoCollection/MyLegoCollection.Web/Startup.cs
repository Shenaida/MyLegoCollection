using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLegoCollection.Web.Startup))]
namespace MyLegoCollection.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

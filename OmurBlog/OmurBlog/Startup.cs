using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OmurBlog.Startup))]
namespace OmurBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

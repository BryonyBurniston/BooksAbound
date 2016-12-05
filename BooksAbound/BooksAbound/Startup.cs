using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksAbound.Startup))]
namespace BooksAbound
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

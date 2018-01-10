using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploAjaxPartialView.Startup))]
namespace ExemploAjaxPartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

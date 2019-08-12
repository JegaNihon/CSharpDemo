using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonarDemo.Startup))]
namespace SonarDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

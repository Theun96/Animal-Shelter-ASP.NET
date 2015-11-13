using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Animal_Shelter_ASP.NET.Startup))]
namespace Animal_Shelter_ASP.NET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

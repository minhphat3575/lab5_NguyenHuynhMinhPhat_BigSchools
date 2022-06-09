using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab5_NguyenHuynhMinhPhat_BigSchools.Startup))]
namespace lab5_NguyenHuynhMinhPhat_BigSchools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

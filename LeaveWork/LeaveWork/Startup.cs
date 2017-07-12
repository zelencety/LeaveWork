using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeaveWork.Startup))]
namespace LeaveWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

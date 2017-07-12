using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeaveWorkSln.Startup))]
namespace LeaveWorkSln
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

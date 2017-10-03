using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobRecorder.Startup))]
namespace JobRecorder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

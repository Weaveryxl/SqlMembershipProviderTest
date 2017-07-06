using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqlMembershipProviderTest.Startup))]
namespace SqlMembershipProviderTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

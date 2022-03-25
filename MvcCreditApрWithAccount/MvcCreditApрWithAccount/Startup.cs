using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCreditApрWithAccount.Startup))]
namespace MvcCreditApрWithAccount
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokemonGoMonsterOpenMap.Startup))]
namespace PokemonGoMonsterOpenMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

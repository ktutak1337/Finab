using System.Runtime.CompilerServices;
using Finab.Modules.Wallets.Core;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("Finab.Bootstrapper")]
namespace Finab.Modules.Wallets.Api
{
    internal static class Extensions
    {
        public static IServiceCollection AddWallets(this IServiceCollection services)
        {
            services.AddCore();
            
            return services;
        }
    }
}

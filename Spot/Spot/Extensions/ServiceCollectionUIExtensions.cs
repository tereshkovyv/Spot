using Microsoft.Extensions.DependencyInjection;
using Spot.Data.Models;
using Spot.DataLayer.Interfaces;
using Spot.DataLayer.Repositories;

namespace Spot.Extensions
{
    public static class ServiceCollectionUiExtensions
    {
        public static void AddDataBaseRepository(this IServiceCollection builder)
        {
            var interfaces = typeof(SocialObjectRepository).GetInterfaces();
            foreach (var interfaceType in interfaces)
                builder.AddTransient(interfaceType, typeof(SocialObjectRepository));
        }
    }
}
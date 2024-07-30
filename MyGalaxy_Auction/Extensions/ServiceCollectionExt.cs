using MyGalaxy_Auction_Business.Abstract;
using MyGalaxy_Auction_Business.Concreate;
using MyGalaxy_Auction_Core.Models;

namespace MyGalaxy_Auction.Extensions
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services,IConfiguration configuration)
        {
            #region services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped(typeof(ApiResponse));
            #endregion
            return services;
        }
    }
}

using MySql.Data.MySqlClient;
using OnlineShop.Repository;
using OnlineShop.Services;
using System.Configuration;

namespace OnlineShop.Extensions
{

    public static class StartupExtension
    {
        public static void AddRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton(_ => new MySqlConnection(connectionString));
            services.AddTransient<UserRepository>();
            services.AddTransient<BrandRepository>();
            services.AddTransient<ProductRepository>();
            services.AddTransient<CategoryRepository>();
            services.AddTransient<OrderProductRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {

            services.AddTransient<UserService>();
            services.AddTransient<AccountService>();
        }


    }
}
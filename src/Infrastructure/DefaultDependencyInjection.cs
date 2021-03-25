using ECommerceSample.Infrastructure.DB;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceSample.Infrastructure
{
    /// <summary>
    /// インフラストラクチャの規定のDI設定
    /// </summary>
    public static class DefaultDependencyInjection
    {
        /// <summary>
        ///  インフラストラクチャの規定のDI設定を追加する
        /// </summary>
        /// <param name="services">サービス</param>
        /// <returns>サービス</returns>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceDbContext>();
            services.AddDbContext<SqliteECommerceDbContext>();

            return services;
        }
    }
}

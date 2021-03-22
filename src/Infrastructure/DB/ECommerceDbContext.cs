using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ECommerceSample.Infrastructure.DB
{
    /// <summary>
    /// EコマースDBコンテキスト
    /// </summary>
    public class ECommerceDbContext : DbContext
    {
        /// <summary>
        /// EコマースDBコンテキスト
        /// </summary>
        /// <param name="options">DBコンテキストオプション</param>
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

        /// <summary>
        /// モデル構成
        /// </summary>
        /// <param name="builder">モデルビルダー</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

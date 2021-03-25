using Microsoft.EntityFrameworkCore;

namespace ECommerceSample.Infrastructure.DB
{
    /// <summary>
    /// 
    /// </summary>
    public class SqliteECommerceDbContext : ECommerceDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public SqliteECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source=ECommerce.sqlite");
        }
    }
}

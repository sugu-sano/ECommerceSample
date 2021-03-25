using ECommerceSample.Infrastructure.DB.Tables.AdminAccounts;
using ECommerceSample.Infrastructure.DB.Tables.AdminPermissions;
using ECommerceSample.Infrastructure.DB.Tables.AdminRoles;
using Microsoft.EntityFrameworkCore;

namespace ECommerceSample.Infrastructure.DB
{
    /// <summary>
    /// EコマースDBコンテキスト
    /// </summary>
    public class ECommerceDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<AdminAccount> AdminAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<AdminAccountRole> AdminAccountRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<AdminRole> AdminRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<AdminRolePermission> AdminRolePermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<AdminPermission> AdminPermissions { get; set; }

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
            builder.ApplyConfiguration<AdminAccount>(new AdminAccountConfiguration());
            builder.ApplyConfiguration(new AdminAccountRoleConfiguration());
            builder.ApplyConfiguration<AdminRole>(new AdminRoleConfiguration());
            builder.ApplyConfiguration(new AdminRolePermissionConfiguration());
            builder.ApplyConfiguration<AdminPermission>(new AdminPermissionConfiguration());
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminAccounts
{
    /// <summary>
    /// 管理者アカウント・管理者ロール中間テーブルの設定
    /// </summary>
    public class AdminAccountRoleConfiguration : IEntityTypeConfiguration<AdminAccountRole>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<AdminAccountRole> builder)
        {
            builder.HasKey(adminAccountRole => new { adminAccountRole.AdminAccountId, adminAccountRole.AdminRoleId });

            builder.HasOne(adminAccountRole => adminAccountRole.AdminAccount)
                .WithMany(adminAccount => adminAccount.AdminAccountRoles)
                .HasForeignKey(adminAccountRole => adminAccountRole.AdminAccountId);

            builder.HasOne(adminAccountRole => adminAccountRole.AdminRole)
                .WithMany(adminRole => adminRole.AdminAccountRoles)
                .HasForeignKey(adminAccountRole => adminAccountRole.AdminRoleId);
        }
    }
}

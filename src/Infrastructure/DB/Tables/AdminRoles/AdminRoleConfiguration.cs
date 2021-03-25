using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminRoles
{
    /// <summary>
    /// 管理者ロールテーブルの設定
    /// </summary>
    public class AdminRoleConfiguration : TableBaseConfiguration, IEntityTypeConfiguration<AdminRole>
    {
        /// <summary>
        /// 管理者ロールを設定する
        /// </summary>
        /// <param name="builder">管理者ロールテーブルの構成を組み立てる</param>
        public void Configure(EntityTypeBuilder<AdminRole> builder)
        {
            builder.HasIndex(adminRole => adminRole.RoleName)
                .IsUnique(true);

            builder.Property(adminRole => adminRole.RoleName)
                .IsRequired(true);

            builder.Property(adminRole => adminRole.Enabled)
                .IsRequired(true);
        }
    }
}

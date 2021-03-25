using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminAccounts
{
    /// <summary>
    /// 管理者アカウントテーブルの設定
    /// </summary>
    public class AdminAccountConfiguration : TableBaseConfiguration, IEntityTypeConfiguration<AdminAccount>
    {
        /// <summary>
        /// 管理者アカウントテーブルを設定する
        /// </summary>
        /// <param name="builder">管理者アカウントテーブルを構成をビルドする</param>
        public void Configure(EntityTypeBuilder<AdminAccount> builder)
        {
            builder.Property(adminAccount => adminAccount.AccountName)
                .IsRequired(true);

            builder.Property(adminAccount => adminAccount.Enabled)
                .IsRequired(true);
        }
    }
}

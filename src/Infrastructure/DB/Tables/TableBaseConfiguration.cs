using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSample.Infrastructure.DB.Tables
{
    /// <summary>
    ///  基底テーブルの設定
    /// </summary>
    public abstract class TableBaseConfiguration : IEntityTypeConfiguration<TableBase>
    {
        /// <summary>
        /// 基底テーブルを構成する
        /// </summary>
        /// <param name="builder">基底テーブルの構成ビルダー</param>
        public void Configure(EntityTypeBuilder<TableBase> builder)
        {
            builder.HasKey(tableBase => tableBase.Id);

            builder.Property(tableBase => tableBase.CreateAt)
                .IsRequired(true);

            builder.Property(tableBase => tableBase.UpdatedAt)
                .IsRequired(false);
        }
    }
}

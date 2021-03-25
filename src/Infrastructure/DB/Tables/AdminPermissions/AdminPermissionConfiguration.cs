using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminPermissions
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminPermissionConfiguration : TableBaseConfiguration, IEntityTypeConfiguration<AdminPermission>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<AdminPermission> builder)
        {
            builder.HasIndex(adminPermission => adminPermission.PermissionName)
                .IsUnique(true);

            builder.Property(adminPermission => adminPermission.PermissionName)
                .IsRequired(true);
        }
    }
}

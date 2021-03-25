using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminRoles
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminRolePermissionConfiguration : IEntityTypeConfiguration<AdminRolePermission>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<AdminRolePermission> builder)
        {
            builder.HasKey(adminRolePermission => new { adminRolePermission.AdminRoleId, adminRolePermission.AdminPermissionId });

            builder.HasOne(adminRolePermission => adminRolePermission.AdminRole)
                .WithMany(adminRole => adminRole.AdminRolePermissions)
                .HasForeignKey(adminRolePermission => adminRolePermission.AdminRoleId);

            builder.HasOne(adminRolePermission => adminRolePermission.AdminPermission)
                .WithMany(adminPermission => adminPermission.AdminRolePermissions)
                .HasForeignKey(adminRolePermission => adminRolePermission.AdminPermissionId);
        }
    }
}

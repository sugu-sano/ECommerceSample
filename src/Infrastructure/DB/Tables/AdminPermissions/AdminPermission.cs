using ECommerceSample.Infrastructure.DB.Tables.AdminRoles;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminPermissions
{
    /// <summary>
    /// 管理者パーミッション
    /// </summary>
    public record AdminPermission : TableBase
    {
        /// <summary>
        /// パーミッション名
        /// </summary>
        public string PermissionName { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public AdminRolePermission[] AdminRolePermissions { get; init; }
    }
}

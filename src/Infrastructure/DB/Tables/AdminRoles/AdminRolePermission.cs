using ECommerceSample.Infrastructure.DB.Tables.AdminPermissions;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminRoles
{
    /// <summary>
    /// 管理者ロール・パーミッション中間テーブル
    /// </summary>
    public record AdminRolePermission
    {
        /// <summary>
        /// 管理者ロールID
        /// </summary>
        public int AdminRoleId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public AdminRole AdminRole { get; init; }

        /// <summary>
        /// 管理者パーミッションID
        /// </summary>
        public int AdminPermissionId { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public AdminPermission AdminPermission { get; init; }
    }
}

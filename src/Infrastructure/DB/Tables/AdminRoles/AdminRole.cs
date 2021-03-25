using ECommerceSample.Infrastructure.DB.Tables.AdminAccounts;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminRoles
{
    /// <summary>
    /// 管理者ロールテーブル
    /// </summary>
    public record AdminRole : TableBase
    {
        /// <summary>
        /// ロール名
        /// </summary>
        public string RoleName { get; init; }

        /// <summary>
        /// 有効かどうか
        /// </summary>
        public bool Enabled { get; init; }

        /// <summary>
        /// 管理者アカウント・管理者ロール中間テーブルのレコード一覧
        /// </summary>
        public AdminAccountRole[] AdminAccountRoles { get; init; }

        /// <summary>
        /// 
        /// </summary>
        public AdminRolePermission[] AdminRolePermissions { get; init; }
    }
}

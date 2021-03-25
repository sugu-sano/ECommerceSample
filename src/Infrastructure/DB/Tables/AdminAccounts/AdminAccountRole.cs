using ECommerceSample.Infrastructure.DB.Tables.AdminRoles;

namespace ECommerceSample.Infrastructure.DB.Tables.AdminAccounts
{
    /// <summary>
    /// 管理者アカウント・管理者ロールの中間テーブル
    /// </summary>
    public record AdminAccountRole
    {
        /// <summary>
        /// 管理者アカウントID
        /// </summary>
        public int AdminAccountId { get; init; }

        /// <summary>
        /// 管理者アカウント
        /// </summary>
        public AdminAccount AdminAccount { get; init; }

        /// <summary>
        /// 管理者ロールID
        /// </summary>
        public int AdminRoleId { get; init; }

        /// <summary>
        /// 管理者ロール
        /// </summary>
        public AdminRole AdminRole { get; init; }
    }
}

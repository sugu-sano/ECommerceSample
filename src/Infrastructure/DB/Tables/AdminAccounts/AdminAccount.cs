namespace ECommerceSample.Infrastructure.DB.Tables.AdminAccounts
{
    /// <summary>
    /// 管理者アカウントテーブル
    /// </summary>
    public record AdminAccount : TableBase
    {
        /// <summary>
        /// アカウント名
        /// </summary>
        public string AccountName { get; init; }

        /// <summary>
        /// 有効かどうか
        /// </summary>
        public bool Enabled { get; init; }

        /// <summary>
        /// 管理者ロールのレコード一覧
        /// </summary>
        public AdminAccountRole[] AdminAccountRoles { get; init; }
    }
}
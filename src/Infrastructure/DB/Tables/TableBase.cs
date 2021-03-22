using System;

namespace ECommerceSample.Infrastructure.DB.Tables
{
    /// <summary>
    /// 基底テーブル
    /// </summary>
    public abstract record TableBase
    {
        /// <summary>
        /// 主キー
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// レコード作成日時
        /// </summary>
        public DateTime CreateAt { get; init; }

        /// <summary>
        /// レコード更新日時
        /// </summary>
        public DateTime? UpdatedAt { get; init; }
    }
}

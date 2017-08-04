using System.ComponentModel;

namespace NbCloud.BaseLib.Activities
{
    /// <summary>
    /// 活动状态
    /// </summary>
    [Description("活动状态")]
    public enum ActivityStatus
    {
        /// <summary>
        /// 未开始
        /// </summary>
        [Description("未开始")]
        NotStarted = 0,
        /// <summary>
        /// 进行中
        /// </summary>
        [Description("进行中")]
        InProgress = 1,
        /// <summary>
        /// 已结束
        /// </summary>
        [Description("已结束")]
        Finished = 2,
        /// <summary>
        /// 已归档
        /// </summary>
        [Description("已归档")]
        Archived = 3
    }
}
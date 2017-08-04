using System;

namespace NbCloud.BaseLib.Activities
{
    /// <summary>
    /// 活动完成数量统计
    /// </summary>
    public class ActivityUser : NbEntity<ActivityUser>
    {
        /// <summary>
        /// 用户
        /// </summary>
        public virtual Guid UserId { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public virtual string UserName { get; set; }
        /// <summary>
        /// 活动Id
        /// </summary>
        public virtual Guid ActivityId { get; set; }
        /// <summary>
        /// 活动类型
        /// </summary>
        public virtual string ActivityType { get; set; }
        /// <summary>
        /// 活动类型名称
        /// </summary>
        public virtual string ActivityTypeName { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public virtual bool IsComplete { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public virtual DateTime? CompleteTime { get; set; }
        /// <summary>
        /// 参加活动时间
        /// </summary>
        public virtual DateTime JoinTime { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public virtual ActivityUserType UserType { get; set; }
    }

    public class NbEntity<T>
    {
    }
}

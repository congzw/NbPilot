using System;

namespace NbCloud.BaseLib.Activities
{
    /// <summary>
    /// 活动参与人类型
    /// </summary>
    [Flags]
    public enum ActivityUserType
    {
        /// <summary>
        /// 创建人
        /// </summary>
        Creator = 1,
        /// <summary>
        /// 授课人
        /// </summary>
        Teacher = 2,
        /// <summary>
        /// 评课人
        /// </summary>
        Expert = 4,
    }
}

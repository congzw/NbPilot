using System;

namespace NbCloud.BaseLib.Activities.ExchangeDatas
{
    /// <summary>
    /// 我的数据
    /// </summary>
    public interface IMyData
    {
        /// <summary>
        /// 用户的Id
        /// </summary>
        Guid UserId { get; set; }
    }

    public interface IMyRole
    {
        string RoleCode { get; set; }
    }

}

using System.Collections.Generic;

namespace NbCloud.BaseLib.My.MyCommonOps
{
    /// <summary>
    /// 常用菜单提供者
    /// </summary>
    public interface IMyCommonOpProvider
    {
        /// <summary>
        /// 获取我的常用操作菜单
        /// </summary>
        /// <param name="myUserInfo"></param>
        /// <returns></returns>
        IList<MyCommonOp> GetMyCommonOps(MyUserInfo myUserInfo);
    }
}
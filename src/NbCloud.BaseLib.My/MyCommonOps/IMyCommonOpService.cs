using System.Collections.Generic;

namespace NbCloud.BaseLib.My.MyCommonOps
{
    /// <summary>
    /// 我的常用操作服务接口
    /// </summary>
    public interface IMyCommonOpService
    {
        /// <summary>
        /// 获取我的常用操作
        /// </summary>
        /// <param name="myUserInfo"></param>
        /// <returns></returns>
        IList<MyCommonOp> GetAllMyCommonOps(MyUserInfo myUserInfo);
    }
}
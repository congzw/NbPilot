using System.Collections.Generic;
using System.Linq;

namespace NbCloud.BaseLib.My.MyCommonOps
{
    /// <summary>
    /// 我的常用操作服务接口
    /// </summary>
    public class MyCommonOpService : IMyCommonOpService
    {
        private readonly IList<IMyCommonOpProvider> _myCommonOpProviders;

        public MyCommonOpService(IList<IMyCommonOpProvider> myCommonOpProviders)
        {
            _myCommonOpProviders = myCommonOpProviders;
        }

        /// <summary>
        /// 获取我的常用操作
        /// </summary>
        /// <param name="myUserInfo"></param>
        /// <returns></returns>
        public IList<MyCommonOp> GetAllMyCommonOps(MyUserInfo myUserInfo)
        {
            if (_myCommonOpProviders == null)
            {
                return new List<MyCommonOp>();
            }
            var myCommonOps = _myCommonOpProviders.SelectMany(x => x.GetMyCommonOps(myUserInfo)).ToList();
            return myCommonOps;
        }
    }
}

using System.Collections.Generic;
using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My.MyCommonWorks
{
    public class MyCommonWorkProvider : IMyWidgetProvider<MyCommonWork>
    {
        /// <summary>
        /// 返回我的组件
        /// </summary>
        /// <param name="nbUser"></param>
        /// <returns></returns>
        public IList<MyCommonWork> SupplyMyWidgets(INbUser nbUser)
        {
            //todo 中间库集中，统一提供
            if (nbUser == null)
            {
                return new List<MyCommonWork>();
            }
            throw new System.NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My.MyCommonWorks
{
    public class MyCommonWorkProvider : IMyWidgetProvider<MyCommonWork>
    {
        /// <summary>
        /// 返回我的组件
        /// </summary>
        /// <param name="myWidgetContext"></param>
        /// <returns></returns>
        public IList<MyCommonWork> SupplyMyWidgets(IMyWidgetContext myWidgetContext)
        {
            //todo 中间库集中，统一提供
            if (myWidgetContext == null)
            {
                return new List<MyCommonWork>();
            }
            throw new System.NotImplementedException();
        }
    }
}

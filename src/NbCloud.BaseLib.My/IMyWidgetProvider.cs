using System.Collections.Generic;
using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My
{
    public interface IMyWidgetProvider<T> where T : IMyWidget
    {
        /// <summary>
        /// 返回我的组件
        /// </summary>
        /// <param name="nbUser"></param>
        /// <returns></returns>
        IList<T> SupplyMyWidgets(INbUser nbUser);
    }
}
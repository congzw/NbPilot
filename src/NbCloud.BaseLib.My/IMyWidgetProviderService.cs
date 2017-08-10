using System.Collections.Generic;
using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My
{
    public interface IMyWidgetProviderService<T> where T : IMyWidget
    {
        /// <summary>
        /// 返回我的组件
        /// </summary>
        /// <param name="myWidgetContext"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        IList<T> GetAllMyWidgets(IMyWidgetContext myWidgetContext, string position = null);
    }
}
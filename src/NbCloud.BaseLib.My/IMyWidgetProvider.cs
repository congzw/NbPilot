using System.Collections.Generic;

namespace NbCloud.BaseLib.My
{
    public interface IMyWidgetProvider<T> where T : IMyWidget
    {
        /// <summary>
        /// 返回我的组件
        /// </summary>
        /// <param name="myWidgetContext"></param>
        /// <returns></returns>
        IList<T> SupplyMyWidgets(IMyWidgetContext myWidgetContext);
    }
}
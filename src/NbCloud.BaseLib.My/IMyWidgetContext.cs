using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My
{
    /// <summary>
    /// 组件上下文
    /// </summary>
    public interface IMyWidgetContext
    {
        /// <summary>
        /// 当前用户
        /// </summary>
        INbUser CurrentUser { get; set; }
    }
}
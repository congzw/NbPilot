using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My
{
    /// <summary>
    /// ���������
    /// </summary>
    public interface IMyWidgetContext
    {
        /// <summary>
        /// ��ǰ�û�
        /// </summary>
        INbUser CurrentUser { get; set; }
    }
}
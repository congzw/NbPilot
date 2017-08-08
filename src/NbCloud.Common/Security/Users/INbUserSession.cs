namespace NbCloud.Common.Security.Users
{
    public interface INbUserSession : IDependency
    {
        /// <summary>
        /// 获取当前
        /// </summary>
        /// <returns></returns>
        INbUser GetCurrent();
    }
}
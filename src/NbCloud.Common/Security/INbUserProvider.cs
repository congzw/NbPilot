namespace NbCloud.Common.Security
{
    public interface INbUserProvider : IDependency
    {
        /// <summary>
        /// 获取当前
        /// </summary>
        /// <returns></returns>
        INbUser GetCurrent();
    }
}
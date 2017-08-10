namespace NbCloud.Common.Security.Sessions
{
    public interface INbSessionService
    {
        /// <summary>
        /// 获取当前UserSession
        /// </summary>
        /// <returns></returns>
        INbSession GetNbSession();
    }
}
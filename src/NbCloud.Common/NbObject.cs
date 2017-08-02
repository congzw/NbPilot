namespace NbCloud.Common
{
    /// <summary>
    /// 弱类型约束接口
    /// </summary>
    public interface INbObject
    {
    }

    /// <summary>
    /// 弱类型约束接口扩展
    /// </summary>
    public static class INbObjectExtensions
    {
        /// <summary>
        /// 转换弱类型约束接口为具体类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nbObject"></param>
        /// <returns></returns>
        public static T As<T>(this INbObject nbObject) where T : class, INbObject
        {
            return nbObject as T;
        }
    }
}

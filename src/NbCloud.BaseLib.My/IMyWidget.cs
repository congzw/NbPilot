namespace NbCloud.BaseLib.My
{
    /// <summary>
    /// 我的组件模型
    /// </summary>
    public interface IMyWidget
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        string UserId { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        string LoginName { get; set; }

        /// <summary>
        /// 提供于哪个模块
        /// </summary>
        string SupplyFromArea { get; set; }
        /// <summary>
        /// 要防止的位置Id
        /// </summary>
        string RenderPosition { get; set; }
        /// <summary>
        /// 排序码，数越小则应越靠前
        /// </summary>
        double SortNum { get; set; }
        /// <summary>
        /// 模板内容或者模板文件地址，如果提供者不想干预则默认行为，则不需要设置
        /// </summary>
        string Template { get; set; }
    }
}
namespace NbCloud.BaseLib.My.MyCommonOps
{
    /// <summary>
    /// 我的常用操作
    /// </summary>
    public class MyCommonOp
    {
        /// <summary>
        /// 来自模块
        /// </summary>
        public string FromArea { get; set; }
        /// <summary>
        /// 位置信息
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public string Pk { get; set; }
        /// <summary>
        /// 父键
        /// </summary>
        public string ParentPk { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public double SortNum { get; set; }
        /// <summary>
        /// 文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// 是否因权限等问题禁止访问
        /// </summary>
        public bool Disabled { get; set; }
    }
}
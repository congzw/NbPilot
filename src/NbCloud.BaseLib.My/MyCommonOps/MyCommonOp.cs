namespace NbCloud.BaseLib.My.MyCommonOps
{
    /// <summary>
    /// 我的常用操作
    /// </summary>
    public class MyCommonOp : IMyWidget
    {
        public MyCommonOp()
        {
            Template = DefaultTemplate;
        }

        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 来自模块
        /// </summary>
        public string SupplyFromArea { get; set; }
        /// <summary>
        /// 位置信息
        /// </summary>
        public string RenderPosition { get; set; }
        /// <summary>
        /// 模板内容或者模板文件地址，如果提供者不想干预则默认行为，则不需要设置
        /// </summary>
        public string Template { get; set; }

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

        /// <summary>
        /// 提供一个默认的模板文件或模板内容，当模块没有干预则使用默认
        /// </summary>
        public static string DefaultTemplate = @"This is a Demo For NbRazorEngine: <h2>Hello, @Model.Text!</h2>";
    }
}
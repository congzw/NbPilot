using System.Collections.Generic;

namespace NbCloud.BaseLib.My.MyCommonWorks
{
    public class MyCommonWork : IMyWidget
    {
        public MyCommonWork()
        {
            MyWorkKeyOps = new List<MyWorkKeyOp>();
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
        /// 提供于哪个模块
        /// </summary>
        public string SupplyFromArea { get; set; }

        /// <summary>
        /// 要防止的位置Id
        /// </summary>
        public string RenderPosition { get; set; }

        /// <summary>
        /// 排序码，数越小则应越靠前
        /// </summary>
        public double SortNum { get; set; }

        /// <summary>
        /// 模板内容或者模板文件地址，如果提供者不想干预则默认行为，则不需要设置
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string WorkType { get; set; }
        /// <summary>
        /// 类型名
        /// </summary>
        public string WorkName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public WorkStatus Status { get; set; }
        /// <summary>
        /// 状态名
        /// </summary>
        public string StatusName { get; set; }
        
        public IList<MyWorkKeyOp> MyWorkKeyOps { get; set; }
    }
    
    public class MyWorkKeyOp : IMyWorkKeyOp
    {
        /// <summary>
        /// 文本
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 显示文本
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public double SortNum { get; set; }

        /// <summary>
        /// CssClass
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool Hidden { get; set; }
    }

    public enum WorkStatus
    {
    }

    #region declares

    public interface IMyWorkKeyOp : IHtmlLink, ISortNum, IHtmlCss, ICategory, IDisabled, IHidden
    {

    }

    #endregion
}

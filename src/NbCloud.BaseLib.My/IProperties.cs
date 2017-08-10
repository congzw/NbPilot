namespace NbCloud.BaseLib.My
{
    public interface IPk
    {
        /// <summary>
        /// 主键
        /// </summary>
        string Pk { get; set; }
    }

    public interface IParentPk
    {
        /// <summary>
        /// 父键
        /// </summary>
        string ParentPk { get; set; }
    }

    public interface IHtmlCss
    {
        /// <summary>
        /// CssClass
        /// </summary>
        string CssClass { get; set; }
    }

    public interface IHtmlLink
    {
        /// <summary>
        /// 文本
        /// </summary>
        string Text { get; set; }
        /// <summary>
        /// 显示文本
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        string Href { get; set; }
    }

    public interface ISortNum
    {
        /// <summary>
        /// 排序码
        /// </summary>
        double SortNum { get; set; }
    }

    public interface ICategory
    {
        /// <summary>
        /// 分类
        /// </summary>
        string Category { get; set; }
    }

    public interface IDisabled
    {
        /// <summary>
        /// 是否禁用
        /// </summary>
        bool Disabled { get; set; }
    }
    public interface IHidden
    {
        /// <summary>
        /// 是否隐藏
        /// </summary>
        bool Hidden { get; set; }
    }
}

using System.Collections.Generic;
using NbCloud.BaseLib.Activities;

namespace NbCloud.BaseLib.My.MyActivities
{
    public class MyActivityVo
    {
        public MyActivityVo()
        {
            MyActivityKeyOps = new List<MyActivityKeyOp>();
        }

        /// <summary>
        /// 活动类型
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// 活动类型名
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// 活动状态
        /// </summary>
        public ActivityStatus ActivityStatus { get; set; }
        /// <summary>
        /// 活动状态名
        /// </summary>
        public string ActivityStatusName { get; set; }

        public IList<MyActivityKeyOp> MyActivityKeyOps { get; set; }
    }

    public class MyActivityKeyOp : IMyActivityKeyOp
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
    }

    #region declares

    public interface IMyActivityKeyOp : IHtmlLink, ISortNum, IHtmlCss, ICategory
    {

    }

    #endregion
}
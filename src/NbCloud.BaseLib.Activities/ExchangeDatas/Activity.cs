using System;
using System.Collections.Generic;
using System.Linq;
using NbCloud.Common;

namespace NbCloud.BaseLib.Activities.ExchangeDatas
{
    /// <summary>
    /// 包含需要校验授权的操作
    /// </summary>
    public interface IOp
    {
        /// <summary>
        /// 操作的唯一键
        /// </summary>
        string OpPk { get; set; }
    }

    /// <summary>
    /// Html链接
    /// </summary>
    public interface IHtmlLink
    {
        /// <summary>
        /// 名称
        /// </summary>
        string Text { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        string Href { get; set; }
    }

    /// <summary>
    /// 常用操作
    /// </summary>
    public class CommonOp
    {
        /// <summary>
        /// 分类
        /// </summary>
        public string Category { get; set; }
    }

    /// <summary>
    /// 我相关的活动
    /// </summary>
    public class Activity
    {
        public Activity()
        {
            ActivityKeyOps = new List<ActivityKeyOp>();
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        public ActivityState State { get; set; }

        /// <summary>
        /// 关键操作列表
        /// </summary>
        public IList<ActivityKeyOp> ActivityKeyOps { get; set; }
    }

    /// <summary>
    /// 活动关键操作
    /// </summary>
    public class ActivityKeyOp : IHtmlLink, IOp
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// 操作的唯一键
        /// </summary>
        public string OpPk { get; set; }
    }

    public enum ActivityState
    {
        //未开始
        //进行中
        //已结束
    }

    public class ActivityCategory : CustomizeEnum<ActivityCategory>
    {
        public ActivityCategory()
        {
            addOrReplace(1, "TPK", "听评课");
            addOrReplace(2, "ZYZB", "重要直播");
            addOrReplace(3, "RCSK", "日常授课");
        }
    }
}

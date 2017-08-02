using System;
using System.Collections.Generic;
using System.Linq;

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
        public string Catelog { get; set; }
    }

    public class Activity
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        public ActivityState State { get; set; }
    }

    public enum ActivityState
    {
        //未开始
        //进行中
        //已结束
    }

    /// <summary>
    /// 自定义枚举（动态扩展，值不是在编译期决定）
    /// </summary>
    public class CustomizeEnum
    {
        /// <summary>
        /// IntValue
        /// </summary>
        public int IntValue { get; set; }
        /// <summary>
        /// StringValue
        /// </summary>
        public string StringValue { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 注册类型
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="stringValue"></param>
        /// <param name="desc"></param>
        public static void AddOrReplace(int intValue, string stringValue, string desc = null)
        {
            var dic = Instance.RegistryDictionary;
            var customizeEnum = dic[intValue];
            if (customizeEnum == null)
            {
                customizeEnum = new CustomizeEnum();
                dic[intValue] = customizeEnum;
            }
            customizeEnum.IntValue = intValue;
            customizeEnum.StringValue = stringValue;
            customizeEnum.Description = desc ?? stringValue;
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public static IList<CustomizeEnum> GetAll()
        {
            var dic = Instance.RegistryDictionary;
            return dic.Values.ToList();
        }

        #region singleton
        
        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset()
        {
            Instance = new CustomizeEnum();
        }

        public static CustomizeEnum Instance = new CustomizeEnum();

        private CustomizeEnum()
        {
        }

        internal Dictionary<int, CustomizeEnum> RegistryDictionary = new Dictionary<int, CustomizeEnum>();

        #endregion
    }
}

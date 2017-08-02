using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace NbCloud.Common
{
    /// <summary>
    /// 自定义枚举（动态扩展，值不是在编译期决定）
    /// </summary>
    public abstract class CustomizeEnum<T> where T : CustomizeEnum<T>, new()
    {
        #region helpers

        /// <summary>
        /// 是否正常初始化
        /// </summary>
        protected bool Inited { get; set; }
        
        /// <summary>
        /// 注册类型
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="stringValue"></param>
        /// <param name="desc"></param>
        protected void addOrReplace(int intValue, string stringValue, string desc = null)
        {
            var dic = RegistryDictionary;
            var customizeEnum = dic.ContainsKey(intValue) ? dic[intValue] : new CustomizeEnumItem();
            customizeEnum.IntValue = intValue;
            customizeEnum.StringValue = stringValue;
            customizeEnum.Description = desc ?? stringValue;
            dic[intValue] = customizeEnum;
        }

        /// <summary>
        /// 注册类型
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="stringValue"></param>
        /// <param name="desc"></param>
        public static void AddOrReplace(int intValue, string stringValue, string desc = null)
        {
            if (Instance == null)
            {
                throw new InvalidOperationException("不能在构造函数中使用此方法！请使用addOrReplace代替");
            }
            Instance.addOrReplace(intValue, stringValue, desc);
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public static IList<CustomizeEnumItem> GetAll()
        {
            var dic = Instance.RegistryDictionary;
            return dic.Values.ToList();
        }

        /// <summary>
        /// 获取某个
        /// </summary>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static CustomizeEnumItem Get(int intValue)
        {
            var dic = Instance.RegistryDictionary;
            if (!dic.ContainsKey(intValue))
            {
                return null;
            }
            return dic[intValue];
        }

        #endregion

        #region singleton
        
        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset(bool clearInitData = false)
        {
            Instance = new T();
            if (clearInitData)
            {
                Instance.RegistryDictionary.Clear();
            }
        }
        
        internal static T Instance = new T();

        internal IDictionary<int, CustomizeEnumItem> RegistryDictionary = new ConcurrentDictionary<int, CustomizeEnumItem>();

        protected CustomizeEnum()
        {
            Inited = true;
        }

        #endregion
    }

    /// <summary>
    /// CustomizeEnumItem
    /// </summary>
    public class CustomizeEnumItem
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
    }
}

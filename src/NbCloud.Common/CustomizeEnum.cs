using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbCloud.Common
{
    /// <summary>
    /// 自定义枚举（动态扩展，值不是在编译期决定）
    /// </summary>
    public abstract class CustomizeEnum<T> where T : CustomizeEnum<T>, new()
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

        #region static helpers
        /// <summary>
        /// 注册类型
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="stringValue"></param>
        /// <param name="desc"></param>
        public static void AddOrReplace(int intValue, string stringValue, string desc = null)
        {
            var dic = Instance.RegistryDictionary;
            var customizeEnum = dic.ContainsKey(intValue) ? dic[intValue] : new T();
            customizeEnum.IntValue = intValue;
            customizeEnum.StringValue = stringValue;
            customizeEnum.Description = desc ?? stringValue;
            dic[intValue] = customizeEnum;
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public static IList<T> GetAll()
        {
            var dic = Instance.RegistryDictionary;
            return dic.Values.ToList();
        }

        /// <summary>
        /// 获取某个
        /// </summary>
        /// <param name="intValue"></param>
        /// <returns></returns>
        public static T Get(int intValue)
        {
            var dic = Instance.RegistryDictionary;
            if (!dic.ContainsKey(intValue))
            {
                return default(T);
            }
            return dic[intValue];
        }

        #endregion

        #region singleton
        
        /// <summary>
        /// 重置
        /// </summary>
        public static void Reset()
        {
            Instance = new T();
        }

        internal static T Instance = new T();

        internal IDictionary<int, T> RegistryDictionary = new ConcurrentDictionary<int, T>();

        #endregion
    }
}

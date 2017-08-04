using System;
using System.Collections.Generic;
using NbCloud.Common.Extensions;

namespace NbCloud.BaseLib.My
{
    /// <summary>
    /// 我的用户信息（通常指当前用户）
    /// </summary>
    public class MyUserInfo
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserLoginName { get; set; }
        /// <summary>
        /// 用户角色码（逗号分隔）
        /// </summary>
        public string UserRoleCodes { get; set; }

        /// <summary>
        /// 用户角色码列表
        /// </summary>
        /// <returns></returns>
        public IList<string> UserRoleCodeLists()
        {
            if (string.IsNullOrWhiteSpace(UserRoleCodes))
            {
                return new List<string>();
            }
            return UserRoleCodes.ToSplits();
        }
    }
}
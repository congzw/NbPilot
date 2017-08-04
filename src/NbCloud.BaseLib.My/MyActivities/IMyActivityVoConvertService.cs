﻿using System;
using System.Collections.Generic;
using System.Linq;
using NbCloud.BaseLib.Activities;
using NbCloud.Common;

namespace NbCloud.BaseLib.My.MyActivities
{
    /// <summary>
    /// 我的工作安排（活动转换服务）
    /// </summary>
    public interface IMyActivityVoConvertService
    {
        /// <summary>
        /// 转换成活动展示Vo
        /// </summary>
        /// <param name="myUserInfo"></param>
        /// <param name="activities"></param>
        /// <returns></returns>
        IList<MyActivityVo> ConvertToVos(MyUserInfo myUserInfo, IList<Activity> activities);
    }

    /// <summary>
    /// 我的工作安排（活动相关）
    /// </summary>
    public class MyActivityVoConvertService : IMyActivityVoConvertService
    {
        private readonly IList<IMyActivityVoConvert> _myActivityVoConverts;

        public MyActivityVoConvertService(IList<IMyActivityVoConvert> myActivityVoConverts)
        {
            _myActivityVoConverts = myActivityVoConverts;
        }

        /// <summary>
        /// 转换成活动展示Vo
        /// </summary>
        /// <param name="myUserInfo"></param>
        /// <param name="activities"></param>
        /// <returns></returns>
        public IList<MyActivityVo> ConvertToVos(MyUserInfo myUserInfo, IList<Activity> activities)
        {
            if (_myActivityVoConverts == null)
            {
                throw new InvalidOperationException("没有发现Vo转换提供程序");
            }

            var myActivityVos = new List<MyActivityVo>();

            foreach (var activity in activities)
            {
                var activityType = activity.ActivityType;
                var myActivityVoConvert = _myActivityVoConverts.SingleOrDefault(x => activityType.NbEquals(x.ForActivityType));
                if (myActivityVoConvert == null)
                {
                    throw new InvalidOperationException(string.Format("没有为活动类型:（{0}）找到转换提供程序", activityType));
                }

                var myActivityVo = myActivityVoConvert.ConvertToVo(myUserInfo, activity);
                myActivityVos.Add(myActivityVo);
            }

            return myActivityVos;
        }
    }
}
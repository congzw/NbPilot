using NbCloud.BaseLib.Activities;

namespace NbCloud.BaseLib.My.MyActivities
{
    /// <summary>
    /// 活动展示Vo提供者接口
    /// </summary>
    public interface IMyActivityVoProvider
    {
        /// <summary>
        /// 转换活动类型，每种类型提供一个转换器
        /// </summary>
        string ForActivityType { get; set; }
        /// <summary>
        /// 转换成跟我相关的活动Vo
        /// </summary>
        /// <param name="myUserInfo"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        MyActivityVo GetMyActivityVo(MyUserInfo myUserInfo, Activity activity);
    }
    
    //统一接口命名（Not Convert）
    //统一用户上下文
}
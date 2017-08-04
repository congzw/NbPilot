using System;

namespace NbCloud.BaseLib.Activities
{
    /// <summary>
    /// 活动记录
    /// </summary>
    public class Activity : NbEntity<Activity>
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        public virtual Guid ActivityId { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public virtual string ActivityName { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public virtual Guid CreatorId { get; set; }
        /// <summary>
        /// 创建者名称
        /// </summary>
        public virtual string CreatorName { get; set; }
        /// <summary>
        /// 教师Id
        /// </summary>
        public virtual Guid? TeacherId { get; set; }
        /// <summary>
        /// 授课教师名称
        /// </summary>
        public virtual string TeacherName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime DateCreated { get; set; }
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public virtual DateTime BeginTime { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        public virtual DateTime EndTime { get; set; }

        /// <summary>
        /// 活动标签
        /// </summary>
        public virtual string Tags { get; set; }
        /// <summary>
        /// 活动类型
        /// </summary>
        public virtual string ActivityType { get; set; }
        /// <summary>
        /// 活动名称
        /// </summary>
        public virtual string ActivityTypeName { get; set; }
        /// <summary>
        /// 学科Code
        /// </summary>
        public virtual string SubjectCode { get; set; }
        /// <summary>
        /// 学科名称
        /// </summary>
        public virtual string SubjectName { get; set; }
        /// <summary>
        /// 年级Code
        /// </summary>
        public virtual string GradeCode { get; set; }
        /// <summary>
        /// 年级名称
        /// </summary>
        public virtual string GradeName { get; set; }
        /// <summary>
        /// 学段
        /// </summary>
        public virtual string PhaseCode { get; set; }
        /// <summary>
        /// 学段名称
        /// </summary>
        public virtual string PhaseName { get; set; }

        /// <summary>
        /// 活动参与用户数量
        /// </summary>
        public virtual int UsersAmount { get; set; }
        /// <summary>
        /// 活动级别
        /// </summary>
        public virtual string ActivityLevelName { get; set; }

        /// <summary>
        /// 活动报告数量
        /// </summary>
        public virtual int ReportsAmount { get; set; }
        /// <summary>
        /// 删除的不再参与统计
        /// </summary>
        public virtual bool IsDeleted { get; set; }
        /// <summary>
        /// 元数据
        /// 想放啥就放点啥
        /// </summary>
        public virtual string Data { get; set; }

        /// <summary>
        /// 组织Id
        /// </summary>
        public virtual Guid? OrgId { get; set; }
        /// <summary>
        /// 组织名称
        /// </summary>
        public virtual string OrgName { get; set; }
        /// <summary>
        /// 状态 如果为空则根据开始结束时间计算 
        /// </summary>
        public virtual ActivityStatus? Status { get; set; }
        
        /// <summary>
        /// 来源 模块
        /// </summary>
        public virtual string Source { get; set; }
    }
}

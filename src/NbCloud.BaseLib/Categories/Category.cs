using System;

namespace NbCloud.BaseLib.Categories
{
    /// <summary>
    /// 分类树
    /// </summary>
    public class Category : NbEntity<Category>
    {
        /// <summary>
        /// 分类树
        /// </summary>
        public Category()
        {
            CreateDate = DateTime.Now;
        }

        /// <summary>
        /// 关系码(创建后不可变，用于树相关搜索)
        /// </summary>
        public virtual string RelationCode { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 排序（同级）
        /// </summary>
        public virtual double SortNum { get; set; }
        /// <summary>
        /// 自定义的搜索快捷码
        /// </summary>
        public virtual string Tags{ get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public virtual DateTime CreateDate { get; set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public virtual Category Parent { get; set; }

        ///// <summary>
        ///// 父Id
        ///// </summary>
        //public virtual Guid? ParentId { get; set; }
        
        #region for total count

        /// <summary>
        /// 挂接数量（直接）
        /// </summary>
        public virtual int DirectCount { get; set; }
        /// <summary>
        /// 挂接数量（总计）
        /// </summary>
        public virtual int TotalCount { get; set; }

        #endregion
    }

    public class CategoryCountForOrg : NbEntity<CategoryCountForOrg>
    {
        /// <summary>
        /// 分类的Id
        /// </summary>
        public virtual Guid CategoryId { get; set; }
        /// <summary>
        /// 分类的关系码
        /// </summary>
        public virtual string CategoryRelationCode { get; set; }
        /// <summary>
        /// 组织Id
        /// </summary>
        public virtual Guid OrgId { get; set; }
        /// <summary>
        /// 直接挂接的资源数量
        /// </summary>
        public virtual int DirectCount { get; set; }
    }
}

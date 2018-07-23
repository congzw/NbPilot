using System;
using System.Collections.Generic;

namespace NbCloud.BaseLib.Categories.AppServices
{
    public interface ICategoryAppService : IAppService
    {
        /// <summary>
        /// 获取分类
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        IList<dynamic> GetCategories(GetCategoriesArgs args);
    }

    public interface IAppService
    {
    }

    public interface ICategoryManageAppService : ICategoryAppService
    {
        /// <summary>
        /// 创建分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        MessageResult AddCategory(AddCategoryDto model);

        /// <summary>
        /// 删除分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        MessageResult DeleteCategory(DeleteCategoryDto model);
        
        /// <summary>
        /// 编辑分类
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        MessageResult EditCategory(EditCategoryDto model);

        //IList<Category> QueryCategory(QueryCategoryArgs args);

        ///// <summary>
        ///// 获取单个用户
        ///// </summary>
        ///// <param name="args"></param>
        ///// <returns></returns>
        //[ForApp]
        //dynamic GetUser(GetUserArgs args);

        ///// <summary>
        ///// 搜索用户
        ///// </summary>
        ///// <param name="args"></param>
        ///// <returns></returns>
        //[ForApp]
        //PagerQueryResult<dynamic> GetUsers(GetUsersArgs args);

        ///// <summary>
        ///// 检测用户是否存在
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[ForApp]
        //[HttpGet]
        //MessageResult CheckUserExist(CheckUserExistArgs model);

        ///// <summary>
        ///// 创建用户（各种用户类型通用）
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[ForManage]
        //[HttpPost]
        //MessageResult AddUser(AddOrEditUser model);

        ///// <summary>
        ///// 删除用户（批量）
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[ForManage]
        //[HttpPost]
        //MessageResult DeleteUsers(DeleteUsers model);

        ///// <summary>
        ///// 编辑用户
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //[ForManage]
        //[HttpPost]
        //MessageResult EditUser(AddOrEditUser model);

        /////// <summary>
        /////// 更换组织
        /////// </summary>
        /////// <param name="model"></param>
        /////// <returns></returns>
        ////[ForManage]
        ////MessageResult ChangeUserOrgs(ChangeUserOrgs model);

        ////other apis, add when necessary todo 
    }
    
    public class GetCategoriesArgs
    {
        //todo
    }

    public class EditCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double SortNum { get; set; }
        public string Tags { get; set; }
    }

    public class DeleteCategoryDto
    {
        public DeleteCategoryDto()
        {
            Ids = new List<Guid>();
        }
        public IList<Guid> Ids { get; set; }
    }

    public class AddCategoryDto
    {
    }

    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string RelationCode { get; set; }
        public string Name { get; set; }
        public double SortNum { get; set; }
        public string Tags { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? ParentId { get; set; }
    }
}

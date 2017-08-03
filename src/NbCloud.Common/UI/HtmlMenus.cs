using System;
using System.Collections.Generic;
using System.Linq;
using NbCloud.Common.Extensions;

namespace NbCloud.Common.UI
{
    /// <summary>
    /// 菜单项
    /// </summary>
    public class HtmlMenuItem
    {
        /// <summary>
        /// 键
        /// </summary>
        public string Pk { get; set; }
        /// <summary>
        /// 父键
        /// </summary>
        public string ParentPk { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// 文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 样式类
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public double SortNum { get; set; }
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool Visiable { get; set; }

        //todo: extensions for dynamic propertis
        //e.g.: icons, show breadcrumbs, etc...
    }

    /// <summary>
    /// 菜单树
    /// </summary>
    public class HtmlMenuItemTree : HtmlMenuItem
    {
        public HtmlMenuItemTree()
        {
            Children = new List<HtmlMenuItemTree>();
        }

        /// <summary>
        /// 子节点
        /// </summary>
        public IList<HtmlMenuItemTree> Children { get; set; }

        /// <summary>
        /// 当前节点或子孙上是否存在节点
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cascade"></param>
        /// <returns></returns>
        public bool HasNode(string text, bool cascade = true)
        {
            var selfEquals = Text.NbEquals(text);
            if (!cascade)
            {
                return selfEquals;
            }
            return selfEquals || Children.Any(x => x.HasNode(text));
        }
        
        /// <summary>
        /// 列表转换为树
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public static HtmlMenuItemTree ConvertTree(IList<HtmlMenuItem> items)
        {
            HtmlMenuItem rootItem;
            try
            {
                rootItem = items.Single(x => x.ParentPk == null);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("非法的树结构，没有找到唯一的根节点！");
            }

            var root = ConvertTreeNode(rootItem);
            AppendChildren(root, items);
            return root;
        }

        #region helpers

        private static void AppendChildren(HtmlMenuItemTree current, IList<HtmlMenuItem> simpleOrgItems, bool cascade = true)
        {
            var childItems = simpleOrgItems.Where(x => x.ParentPk == current.Pk);
            foreach (var childItem in childItems)
            {
                var childTreeNode = ConvertTreeNode(childItem);
                current.Children.Add(childTreeNode);
                if (cascade)
                {
                    AppendChildren(childTreeNode, simpleOrgItems);
                }
            }
        }

        private static HtmlMenuItemTree ConvertTreeNode(HtmlMenuItem item)
        {
            var treeOrgItem = new HtmlMenuItemTree();
            treeOrgItem.TryCopyPropertiesFrom(item);
            return treeOrgItem;
        }

        #endregion
    }
}

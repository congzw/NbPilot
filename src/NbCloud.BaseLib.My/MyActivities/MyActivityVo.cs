using System.Collections.Generic;
using NbCloud.BaseLib.Activities;

namespace NbCloud.BaseLib.My.MyActivities
{
    public class MyActivityVo
    {
        public MyActivityVo()
        {
            MyActivityKeyOps = new List<MyActivityKeyOp>();
        }

        /// <summary>
        /// �����
        /// </summary>
        public string ActivityType { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// �״̬
        /// </summary>
        public ActivityStatus ActivityStatus { get; set; }
        /// <summary>
        /// �״̬��
        /// </summary>
        public string ActivityStatusName { get; set; }

        public IList<MyActivityKeyOp> MyActivityKeyOps { get; set; }
    }

    public class MyActivityKeyOp : IMyActivityKeyOp
    {
        /// <summary>
        /// �ı�
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// ��ʾ�ı�
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public double SortNum { get; set; }

        /// <summary>
        /// CssClass
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Category { get; set; }
    }

    #region declares

    public interface IMyActivityKeyOp : IHtmlLink, ISortNum, IHtmlCss, ICategory
    {

    }

    #endregion
}
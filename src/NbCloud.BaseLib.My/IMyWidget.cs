namespace NbCloud.BaseLib.My
{
    /// <summary>
    /// �ҵ����ģ��
    /// </summary>
    public interface IMyWidget
    {
        /// <summary>
        /// �û�Id
        /// </summary>
        string UserId { get; set; }
        /// <summary>
        /// ��¼��
        /// </summary>
        string LoginName { get; set; }

        /// <summary>
        /// �ṩ���ĸ�ģ��
        /// </summary>
        string SupplyFromArea { get; set; }
        /// <summary>
        /// Ҫ��ֹ��λ��Id
        /// </summary>
        string RenderPosition { get; set; }
        /// <summary>
        /// �����룬��ԽС��ӦԽ��ǰ
        /// </summary>
        double SortNum { get; set; }
        /// <summary>
        /// ģ�����ݻ���ģ���ļ���ַ������ṩ�߲����Ԥ��Ĭ����Ϊ������Ҫ����
        /// </summary>
        string Template { get; set; }
    }
}
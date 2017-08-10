using System.Collections.Generic;
using System.Linq;
using NbCloud.Common;
using NbCloud.Common.Security.Users;

namespace NbCloud.BaseLib.My
{
    public class WidgetProviderService<TVo> : IMyWidgetProviderService<TVo> where TVo : IMyWidget
    {
        private readonly IList<IMyWidgetProvider<TVo>> _myWidgetProviders;

        public WidgetProviderService(IList<IMyWidgetProvider<TVo>> myWidgetProviders)
        {
            if (myWidgetProviders == null)
            {
                //var exMessage = string.Format("û�з����κ��ṩ����: IMyWidgetProvider<{0}>", typeof(TVo).Name);
                //throw new ArgumentNullException(exMessage);
                _myWidgetProviders = new List<IMyWidgetProvider<TVo>>();
                return;
            }
            _myWidgetProviders = myWidgetProviders;
        }

        /// <summary>
        /// �����ҵ����
        /// </summary>
        /// <param name="myWidgetContext"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public IList<TVo> GetAllMyWidgets(IMyWidgetContext myWidgetContext, string position = null)
        {
            var vos = new List<TVo>();
            var myWidgetProviders = _myWidgetProviders;

            foreach (var myWidgetProvider in myWidgetProviders)
            {
                var supplyMyWidgetVos = myWidgetProvider.SupplyMyWidgets(myWidgetContext);
                vos.AddRange(supplyMyWidgetVos);
            }

            var orderedVos = vos
                    .OrderBy(x => x.RenderPosition)
                    .ThenBy(x => x.SortNum)
                    .ThenBy(x => x.SupplyFromArea).ToList();

            if (!string.IsNullOrWhiteSpace(position))
            {
                orderedVos = orderedVos.Where(x => x.RenderPosition.NbEquals(position)).ToList();
            }
            return orderedVos;
        }
    }
}
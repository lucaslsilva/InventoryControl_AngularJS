using Abp.Web.Mvc.Views;

namespace InventoryControlAngularJS.Web.Views
{
    public abstract class InventoryControlAngularJSWebViewPageBase : InventoryControlAngularJSWebViewPageBase<dynamic>
    {

    }

    public abstract class InventoryControlAngularJSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected InventoryControlAngularJSWebViewPageBase()
        {
            LocalizationSourceName = InventoryControlAngularJSConsts.LocalizationSourceName;
        }
    }
}
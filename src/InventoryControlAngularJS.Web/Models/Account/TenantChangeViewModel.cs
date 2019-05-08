using Abp.AutoMapper;
using InventoryControlAngularJS.Sessions.Dto;

namespace InventoryControlAngularJS.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
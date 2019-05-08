using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InventoryControlAngularJS.MultiTenancy.Dto;

namespace InventoryControlAngularJS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

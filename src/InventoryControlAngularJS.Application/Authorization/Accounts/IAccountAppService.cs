using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryControlAngularJS.Authorization.Accounts.Dto;

namespace InventoryControlAngularJS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

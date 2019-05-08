using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryControlAngularJS.Sessions.Dto;

namespace InventoryControlAngularJS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

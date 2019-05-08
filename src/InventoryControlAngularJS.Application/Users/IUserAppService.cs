using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InventoryControlAngularJS.Roles.Dto;
using InventoryControlAngularJS.Users.Dto;

namespace InventoryControlAngularJS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
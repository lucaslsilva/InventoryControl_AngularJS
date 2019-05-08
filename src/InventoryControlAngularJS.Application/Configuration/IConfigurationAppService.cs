using System.Threading.Tasks;
using Abp.Application.Services;
using InventoryControlAngularJS.Configuration.Dto;

namespace InventoryControlAngularJS.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
using Abp.Authorization;
using InventoryControlAngularJS.Authorization.Roles;
using InventoryControlAngularJS.Authorization.Users;

namespace InventoryControlAngularJS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

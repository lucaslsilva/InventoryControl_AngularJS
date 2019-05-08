using Abp.MultiTenancy;
using InventoryControlAngularJS.Authorization.Users;

namespace InventoryControlAngularJS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
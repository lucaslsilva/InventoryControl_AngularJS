using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using InventoryControlAngularJS.Authorization.Roles;
using InventoryControlAngularJS.Authorization.Users;
using InventoryControlAngularJS.MultiTenancy;

namespace InventoryControlAngularJS.EntityFramework
{
    public class InventoryControlAngularJSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public InventoryControlAngularJSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in InventoryControlAngularJSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of InventoryControlAngularJSDbContext since ABP automatically handles it.
         */
        public InventoryControlAngularJSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public InventoryControlAngularJSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public InventoryControlAngularJSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}

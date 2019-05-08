using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using InventoryControlAngularJS.EntityFramework;

namespace InventoryControlAngularJS
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(InventoryControlAngularJSCoreModule))]
    public class InventoryControlAngularJSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<InventoryControlAngularJSDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using InventoryControlAngularJS.EntityFramework;

namespace InventoryControlAngularJS.Migrator
{
    [DependsOn(typeof(InventoryControlAngularJSDataModule))]
    public class InventoryControlAngularJSMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<InventoryControlAngularJSDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
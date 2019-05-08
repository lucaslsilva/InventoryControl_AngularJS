using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace InventoryControlAngularJS.EntityFramework.Repositories
{
    public abstract class InventoryControlAngularJSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<InventoryControlAngularJSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected InventoryControlAngularJSRepositoryBase(IDbContextProvider<InventoryControlAngularJSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class InventoryControlAngularJSRepositoryBase<TEntity> : InventoryControlAngularJSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected InventoryControlAngularJSRepositoryBase(IDbContextProvider<InventoryControlAngularJSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}

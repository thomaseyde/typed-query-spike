using System.Collections.Generic;
using System.Diagnostics;

namespace typed_queries.Framework
{
    [DebuggerStepThrough]
    static class Query<TEntity>
    {
        public static TEntity One<TCriteria>(TCriteria criteria) where TCriteria : ISpecifyCriteria<TEntity>
        {
            var query = DependencyContainer.Resolve<IQueryOne<TCriteria, TEntity>>();
            return query.Single(criteria);
        }


        public static IEnumerable<TEntity> Many<TCriteria>(TCriteria criteria) where TCriteria : ISpecifyCriteria<TEntity>
        {
            var query = DependencyContainer.Resolve<IQueryMany<TCriteria, TEntity>>();
            return query.All(criteria);
        }
    }
}
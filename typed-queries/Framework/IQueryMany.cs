using System.Collections.Generic;

namespace typed_queries.Framework
{
    internal interface IQueryMany<in TCriteria, out TEntity> where TCriteria : ISpecifyCriteria<TEntity>
    {
        IEnumerable<TEntity> All(TCriteria criteria);
    }
}
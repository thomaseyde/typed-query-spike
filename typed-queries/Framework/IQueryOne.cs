namespace typed_queries.Framework
{
    internal interface IQueryOne<in TCriteria, out TEntity> where TCriteria : ISpecifyCriteria<TEntity>
    {
        TEntity Single(TCriteria criteria);
    }
}
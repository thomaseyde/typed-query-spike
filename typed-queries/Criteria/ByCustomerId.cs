using typed_queries.Framework;
using typed_queries.Models;

namespace typed_queries.Criteria
{
    internal class ByCustomerId : ISpecifyCriteria<Customer>, ISpecifyCriteria<Person> {}
}
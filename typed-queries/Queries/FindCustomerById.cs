using typed_queries.Criteria;
using typed_queries.Framework;
using typed_queries.Models;

namespace typed_queries.Queries
{
    internal class FindCustomerById : IQueryOne<ByCustomerId, Customer>
    {
        public Customer Single(ByCustomerId criteria)
        {
            return new Customer();
        }
    }
}
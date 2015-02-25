using System.Collections.Generic;
using typed_queries.Criteria;
using typed_queries.Framework;
using typed_queries.Models;

namespace typed_queries.Queries
{
    internal class FindCustomersByName : IQueryMany<ByCustomerName, Customer>
    {
        public IEnumerable<Customer> All(ByCustomerName criteria)
        {
            yield return new Customer();
        }
    }
}
using System.Collections.Generic;
using typed_queries.Criteria;
using typed_queries.Framework;
using typed_queries.Models;

namespace typed_queries.Queries
{
    internal class FindCustomerPersons : IQueryMany<ByCustomerId, Person>
    {
        public IEnumerable<Person> All(ByCustomerId criteria)
        {
            yield return new Person();
        }
    }
}
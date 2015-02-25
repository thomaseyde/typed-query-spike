using System.Collections.Generic;
using Machine.Specifications;
using Should;
using typed_queries.Criteria;
using typed_queries.Models;
using typed_queries.Queries;

namespace typed_queries
{
    [Subject("Query")]
    public class Querying_customer_directly
    {
        Establish context = () =>
            {
                identified = new FindCustomerById().Single(new ByCustomerId());
                named = new FindCustomersByName().All(new ByCustomerName());
                persons = new FindCustomerPersons().All(new ByCustomerId());
            };

        It should_get_by_id = () => identified.ShouldNotBeNull();
        It should_get_by_name = () => named.ShouldNotBeEmpty();
        It should_get_persons = () => persons.ShouldNotBeEmpty();

        static Customer identified;
        static IEnumerable<Customer> named;
        static IEnumerable<Person> persons;
    }
}
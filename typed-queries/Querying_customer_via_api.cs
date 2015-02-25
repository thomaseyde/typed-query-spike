using System.Collections.Generic;
using Machine.Specifications;
using Should;
using typed_queries.Criteria;
using typed_queries.Framework;
using typed_queries.Models;

namespace typed_queries
{
    [Subject("Query")]
    public class Querying_customer_via_api
    {
        Establish context = () =>
            {
                identified = Query<Customer>.One(new ByCustomerId());
                named = Query<Customer>.Many(new ByCustomerName());
                persons = Query<Person>.Many(new ByCustomerId());
            };

        It should_get_by_id = () => identified.ShouldNotBeNull();
        It should_get_by_name = () => named.ShouldNotBeEmpty();
        It should_get_persons = () => persons.ShouldNotBeEmpty();

        static Customer identified;
        static IEnumerable<Customer> named;
        static IEnumerable<Person> persons;
    }
}
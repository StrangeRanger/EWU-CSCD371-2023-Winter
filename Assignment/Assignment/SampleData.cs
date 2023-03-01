using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        public IEnumerable<string> CsvRows { get; } = 
            from string line in File.ReadAllLines("People.csv")
            where !line.Contains("Id,FirstName,LastName,Email,StreetAddress,City,State,Zip")
            select line;
        
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            return (from string item in CsvRows 
                    let state = item.Split(',')[6] 
                    orderby state 
                    select state).Distinct();
        }
        
        public string GetAggregateSortedListOfStatesUsingCsvRows()
        {
            return string.Join(", ", GetUniqueSortedListOfStatesGivenCsvRows().ToArray());
        }
        
        public IEnumerable<IPerson> People => from string item in CsvRows
                                              let split = item.Split(',')
                                              orderby split[6], item[5], item[7]
                                              select new Person(split[1], 
                                                                split[2], 
                                                                new Address(split[4], 
                                                                            split[5], 
                                                                            split[6], 
                                                                            split[7]), 
                                                                split[3]);

        
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(Predicate<string> filter)
        {
            IEnumerable<(string FirstName, string LastName)> names =
                from Person person in People
                where filter(person.EmailAddress)
                select (person.FirstName, person.LastName);
            return names;
        }
        
        public string GetAggregateListOfStatesGivenPeopleCollection(IEnumerable<IPerson> people)
        {
            return people.Select(p => p.Address.State).Distinct().Aggregate((a, b) => a + ", " + b);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows { get; init; }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows() 
            => throw new NotImplementedException();

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();

        // 4.
        public IEnumerable<IPerson> People { get; init; }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
        
        public SampleData()
        {
            CsvRows = System.IO.File.ReadAllText("People.csv").Replace("Id,FirstName,LastName,Email,StreetAddress,City,State,Zip\r\n", null).Split("\r\n");
            People = new List<IPerson>();
        }
    }
}

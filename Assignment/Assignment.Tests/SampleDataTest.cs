using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTest
{
#pragma warning disable CS8618
    private SampleData sampleData { get; set; }
#pragma warning restore CS8618

    [TestInitialize]
    public void TestInitialize()
    {
        TestCleanup();
        sampleData = new SampleData();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        sampleData = null !;
    }

    [TestMethod]
    public void SampleData_CountCsvRows_AreEqualIsTrue()
    {
        Assert.AreEqual(50, sampleData.CsvRows.Count());
    }

    [TestMethod]
    public void SampleData_GetUniqueSortedListOfStatesGivenCsvRows_Hardcoded_AreEqualIsTrue()
    {
        List<string> returnedList =
            (List<string>)sampleData.GetUniqueSortedListOfStatesGivenCsvRows();
        List<string> hardcodedListOfStates = new List<string>()
        {
            "AL", "AZ", "CA", "DC", "FL", "GA", "IN", "KS", "LA", "MD", "MN", "MO", "MT", "NC",
            "NE", "NH", "NV", "NY", "OR", "PA", "SC", "TN", "TX", "UT", "VA", "WA", "WV"
        };

        // TODO: Figure out another way of doing this without using CollectionAssert, as requested
        //       in the assignment.
        CollectionAssert.AreEqual(hardcodedListOfStates, returnedList);
    }

    [TestMethod]
    public void SampleData_RetrieveRowUsingSampleData_AreEqualIsTrue()
    {
        Assert.AreEqual("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577",
            sampleData.CsvRows.ElementAt(0));
    }

    [TestMethod]
    public void SampleData_RetrieveRowUsingIEnumerator_AreEqualIsTrue()
    {
        IEnumerator enumerator = sampleData.CsvRows.GetEnumerator();

        enumerator.MoveNext();

        Assert.AreEqual("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577",
            enumerator.Current);
    }

    [TestMethod]
    public void SkipFirstRowOfCsvRows_AreEqualIsTrue()
    {
        Assert.IsFalse(sampleData.CsvRows.ElementAt(0)
            .Contains("Id,FirstName,LastName,Email,StreetAddress,City,State,Zip"));
    }

    //Include a test that uses LINQ to verify the data is sorted correctly (do not use a hardcoded list).
    [TestMethod]
    public void isGetUniqueSortedListOfStatesGivenCsvRowsSorted_AreEqualIsTrue()
    {
        IEnumerable<string> enumerator =
            from string line in sampleData.GetUniqueSortedListOfStatesGivenCsvRows()
            orderby line
            select line;

        for (int i = 0; i < enumerator.Count(); i++)
        {
            Assert.AreEqual(enumerator.ElementAt(i), sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ElementAt(i));
        }
    }
}
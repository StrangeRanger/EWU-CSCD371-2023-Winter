using System;
using System.Collections;
using System.Collections.Generic;
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
        SampleData sampleData = new SampleData();

        Assert.AreEqual(50, sampleData.CsvRows.Count());
    }

    [TestMethod]
    public void SampleData_GetUniqueSortedListOfStatesGivenCsvRows_Hardcoded_AreEqualIsTrue()
    {
        SampleData sampleData = new SampleData();
        List<string> returnedList =
            (List<string>) sampleData.GetUniqueSortedListOfStatesGivenCsvRows();
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
        SampleData sampleData = new SampleData();

        Assert.AreEqual("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577",
                        sampleData.CsvRows.ElementAt(0));
    }

    [TestMethod]
    public void SampleData_RetrieveRowUsingIEnumerator_AreEqualIsTrue()
    {
        SampleData sampleData = new SampleData();
        IEnumerator enumerator = sampleData.CsvRows.GetEnumerator();

        enumerator.MoveNext();

        Assert.AreEqual("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577",
                        enumerator.Current);
    }
}

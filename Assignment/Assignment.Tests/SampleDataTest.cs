using System;
using System.Collections.Generic;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTest
{
    [TestMethod]
    public void TestMethod1()
    {
        _ = new SampleData();
    }
    
    [TestMethod]
    public void CsvRowsTest()
    {
        var sampleData = new SampleData();
        string[] csvRows = (string[])sampleData.CsvRows;
        Assert.AreEqual("1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577", csvRows[1]);
    }
}
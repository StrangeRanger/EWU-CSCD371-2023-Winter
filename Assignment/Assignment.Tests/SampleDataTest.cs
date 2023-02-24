using System;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTest
{
    [TestMethod]
    public void TestMethod1()
    {
        _ = new SampleData();
    }
    
    [ExpectedException(typeof(NotImplementedException))]
    [TestMethod]
    public void CsvRowsTest()
    {
        var sampleData = new SampleData();
        var csvRows = sampleData.CsvRows;
    }
}
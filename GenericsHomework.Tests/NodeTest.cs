namespace GenericsHomework.Tests;

[TestClass]
public class NodeTest
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    
    [TestMethod]
    public void NextNodeIsNotNull()
    {
        Node node = new Node();
        Assert.AreSame(node, node.Next);
    }
}

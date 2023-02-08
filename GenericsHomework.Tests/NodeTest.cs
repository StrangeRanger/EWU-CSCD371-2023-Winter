namespace GenericsHomework.Tests;

[TestClass]
public class NodeTest
{
    [TestMethod]
    public void NextNodeIsNotNull()
    {
        Node<int> node = new Node<int>(19);
        Assert.IsNotNull(node.Next);
    }
}

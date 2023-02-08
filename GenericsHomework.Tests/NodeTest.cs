namespace GenericsHomework.Tests;

[TestClass]
public class NodeTest
{
    [TestMethod]
    public void NextNode_IsNotNull()
    {
        Node<int> node = new Node<int>(19);
        Assert.IsNotNull(node.Next);
    }

    [TestMethod]
    public void NextNode_Append_AreEqualValue()
    {
        Node<int> node = new Node<int>(19);
        node.Append(20);
        node.Append(30);
        Assert.AreEqual(20, node.Next.Value);
    }
}

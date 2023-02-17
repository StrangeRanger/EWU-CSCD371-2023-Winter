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
    [ExpectedException(typeof(NullReferenceException))]
    public void Node_Append_ThrowsNullReferenceException()
    {
        Node<object> node = new Node<object>(null!);
    }

    [TestMethod]
    public void NextNode_Append_AreEqualValue()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);

        Assert.AreEqual<int>(20, node.Next.Value);
        Assert.AreEqual<int>(30, node.Next.Next.Value);
        Assert.AreEqual<int>(40, node.Next.Next.Next.Value);
    }

    [TestMethod]
    public void Node_Clear_NextNodeIsNode()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);

        node.Clear();

        Assert.AreEqual<Node<int> >(node, node.Next);
    }

    [TestMethod]
    public void Node_Contains_ReturnsTrue()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);

        Assert.IsTrue(node.Exists(30));
    }

    [TestMethod]
    public void Node_Contains_ReturnsFalse()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);

        Assert.IsFalse(node.Exists(50));
    }

    [TestMethod]
    [ExpectedException(typeof(DuplicateDataInArrayException))]
    public void Node_Append_ThrowsDuplicateDataInArrayException()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);
        node.Append(40);
    }

    [TestMethod]
    public void ToString_ReturnsString()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);

        Assert.AreEqual<string>("{ 19, 20, 30, 40 }", node.ToString());
    }

    // NOTE: Please pay no mind to this method. I was doing some testing and would like to
    //       keep it here, for future reference.
    /*
    [TestMethod]
    public void Node_CheckLengthBeforeAndAfterClear_AreEqualToFourAndOne()
    {
        Node<int> node = new Node<int>(19);

        node.Append(20);
        node.Append(30);
        node.Append(40);

        Assert.AreEqual(4, node.NumberOfItemsInArray());
        node.Clear();
        Assert.AreEqual(1, node.NumberOfItemsInArray());

        //Assert.AreEqual(node, node.Next);
    }
    */
}

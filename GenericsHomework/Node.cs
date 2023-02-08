namespace GenericsHomework;

public class Node
{
    private Node _nextNode;
    public Node Next {
        get
        {
            if (_nextNode == null)
            {
                return this;
            }
            else
            {
                return _nextNode;
            }
        }
    }
}

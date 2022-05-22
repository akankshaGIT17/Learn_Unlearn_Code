using System;

public class Node
{
    public int value;
    public Node left;
    public Node Right;
    public Node(int n)
    {
        value = n;
    }


}
class call
{
    void Main()
    {
        Node root = new Node(5);
        root.left = new Node(2);
        root.Right = new Node(4);
    }
    void preorder(Node n)
    {
        if (n == null)
            return;
        //jab tak return nhi hoga tab tak recursion chalega
        Console.WriteLine(n.value);
        preorder(n.left);
        preorder(n.Right);
    }
    void inorder(Node n)
    {
        if (n == null)
            return;
        //jab tak return nhi hoga tab tak recursion chalega
        preorder(n.left);
        Console.WriteLine(n.value);
        preorder(n.Right);
    }
    void postorder(Node n)
    {
        if (n == null)
            return;
        //jab tak return nhi hoga tab tak recursion chalega
        preorder(n.left);
        preorder(n.Right);
        Console.WriteLine(n.value);
    }
    // Height: TC: O(n) SC: O(height)
    //void height(Node n)
    //{
    //    if (n == null)
    //        break;
    //    int left = height(n.left);
    //    int right = height(n.Right);
    //    int heightCal = Math.Max(left, right) + 1;
    //}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.LinkList
{
    internal class StackUsingLinkList
    {
        private LLNode top = null;
        private void Push(int val)
        {
            LLNode node = new LLNode();
            if (node == null)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                node.data = val;
                node.next = top;
                top = node;
            }
        }
        private void Pop()
        {
            LLNode node = new LLNode();
            int t = -1;
            if (top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                node = top;
                top = top.next;
                t = Convert.ToInt32(node.data);
                
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.LinkList
{
    internal class InsertAfterNthElement
    {
        void insertAfterNthNode(MyLinkedList obj, LLNode head, int n, int x)
        {
            // if list is empty
            if (head == null)
                return;

            // get a new node for the value 'x'
            LLNode newNode = obj.getNode(x);
            LLNode ptr = head;
            int len = 0, i;

            // find length of the list, i.e, the
            // number of nodes in the list
            while (ptr != null)
            {
                len++;
                ptr = ptr.next;
            }

            // traverse up to the nth node from the end
            ptr = head;
            for (i = 1; i <= (len - n); i++)
                ptr = ptr.next;

            // insert the 'newNode' by making the
            // necessary adjustment in the links
            newNode.next = ptr.next;
            ptr.next = newNode;
        }

        void Caller()
        {
            MyLinkedList linkedListOperations = new MyLinkedList();
            LLNode head = linkedListOperations.getNode(1);
            head.next = linkedListOperations.getNode(3);
            head.next.next = linkedListOperations.getNode(4);
            head.next.next.next = linkedListOperations.getNode(5);

            int n = 4, x = 2;

            Console.Write("Original Linked List: ");
            linkedListOperations.printList(head);

            insertAfterNthNode(linkedListOperations,head, n, x);
            Console.WriteLine();
            Console.Write("Linked List After Insertion: ");
            linkedListOperations.printList(head);
        }
    }
}

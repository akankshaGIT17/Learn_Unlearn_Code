using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.LinkList
{
    internal class DeleteNnodesAfterMnodes
    {
        void skipMdeleteN(LLNode head, int M, int N)
        {
            LLNode curr = head, t;
            int count;

            // The main loop that traverses 
            // through the whole list 
            while (curr != null)
            {
                // Skip M nodes 
                for (count = 1; count < M &&
                        curr != null; count++)
                    curr = curr.next;

                // If we reached end of list, then return 
                if (curr == null)
                    return;

                // Start from next node and delete N nodes 
                t = curr.next;
                for (count = 1; count <= N && t != null; count++)
                {
                    LLNode temp = t;
                    t = t.next;
                }

                // Link the previous list with remaining nodes 
                curr.next = t;

                // Set current pointer for next iteration 
                curr = t;
            }
            void caller()
            {
                MyLinkedList likListDemonstrattion = new MyLinkedList();
                LLNode head = null;
                int M = 2, N = 3;
                head = likListDemonstrattion.push(head, 10);
                head = likListDemonstrattion.push(head, 9);
                head = likListDemonstrattion.push(head, 8);
                head = likListDemonstrattion.push(head, 7);
                head = likListDemonstrattion.push(head, 6);
                head = likListDemonstrattion.push(head, 5);
                head = likListDemonstrattion.push(head, 4);
                head = likListDemonstrattion.push(head, 3);
                head = likListDemonstrattion.push(head, 2);
                head = likListDemonstrattion.push(head, 1);

                Console.Write("M = {0}, N = {1} \nGiven" + 
                                    "Linked list is :\n", M, N);
                likListDemonstrattion.printList(head);

                skipMdeleteN(head, M, N);

                Console.Write("\nLinked list after deletion is :\n");
                likListDemonstrattion.printList(head);
            }
        }

    }
}

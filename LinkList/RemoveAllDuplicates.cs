using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.LinkList
{
    internal class RemoveAllDuplicates
    {
        LLNode head = null;
        public void removeAllDuplicates()
        {
            
            /* create a dummy LLNode that acts like a fake
                head of list pointing to the original head*/
            LLNode dummy = new LLNode();

            /* dummy LLNode points to the original head*/
            dummy.next = head;
            LLNode prev = dummy;
            LLNode current = head;

            while (current != null)
            {
                /* Until the current and previous values
                are same, keep updating current */
                while (current.next != null &&
                    prev.next.data == current.next.data)
                    current = current.next;

                /* if current has unique value i.e current
                    is not updated, Move the prev pointer
                    to next LLNode*/
                if (prev.next == current)
                    prev = prev.next;

                /* when current is updated to the last
                duplicate value of that segment, make
                prev the next of current*/
                else
                    prev.next = current.next;

                current = current.next;
            }

            /* update original head to the next of dummy
            LLNode */
            head = dummy.next;
        }

        void Caller()
        {
            MyLinkedList linkeListDesmonstration = new MyLinkedList();
            linkeListDesmonstration.AddFirst(head,53);
            linkeListDesmonstration.AddFirst(head,53);
            linkeListDesmonstration.AddFirst(head,49);
            linkeListDesmonstration.AddFirst(head,49);
            linkeListDesmonstration.AddFirst(head,35);
            linkeListDesmonstration.AddFirst(head,28);
            linkeListDesmonstration.AddFirst(head,28);
            linkeListDesmonstration.AddFirst(head, 23);
            Console.WriteLine("Before removal of duplicates");
            linkeListDesmonstration.printList(head);

            removeAllDuplicates();

            Console.WriteLine("\nAfter removal of duplicates");
            linkeListDesmonstration.printList(head);
        }

    }
}

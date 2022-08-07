using System;

namespace main.LinkList
{
    internal class ReverseLinkList
    {
        AllLinkListOperations LL = new AllLinkListOperations();
        public void create()
        {
            LL.AddFirst(10);
            LL.AddFirst(9);
            LL.AddFirst(8);
            LL.AddFirst(7);
            LL.AddFirst(6); 
            LL.AddFirst(5); 
            LL.AddFirst(4); 
            LL.AddFirst(3);
            LL.AddFirst(2);
            LL.AddFirst(1);

        }

        public CurrentNode reverse(CurrentNode head)
        {
            var current = head;
            CurrentNode prev = null;
            CurrentNode next = head.next;
            while(current != null)
            {
                current.next = prev;
                prev = current;
                current = next;
                if(next != null)
                next = next.next;

            }
            Console.WriteLine("Reversed");
           return prev;
        }

        public CurrentNode RecursiveReverse(CurrentNode head)
        {
            Console.WriteLine("Recursive Reversed");
            if (head.next == null)
            {
                return head;
            }
            var newHead = RecursiveReverse(head.next);
            head.next.next = head;
            head.next = null;
            return newHead;

        }
        public void Call()
        {
            create();
            LL.printACurrentNodes();
            var reversed = reverse(LL.head);
            LL.printAllLinkedListodes(reversed);
            var recursiveReverse = RecursiveReverse(LL.head);
            LL.printAllLinkedListodes(recursiveReverse);
        }
    }
}

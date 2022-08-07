using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using main.LinkList;

namespace main.LinkList
{
    public class CurrentNode
    {
        public CurrentNode next;
        public int data;
    }
    public class AllLinkListOperations
    {
         
        public CurrentNode head;

        public void printACurrentNodes()
        {
            CurrentNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void printAllLinkedListodes(CurrentNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void AddFirst(int data)
        {
            CurrentNode toAdd = new CurrentNode();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }
        public void Length(CurrentNode head) { 
        int sum=0;
            var temp = head;
            while (temp != null)
            {
                sum++;
                temp = temp.next;
            }
            Console.WriteLine("Link List count : "+sum);
        }
        public void BinaryNumberConversion(CurrentNode head)
        {
            int ans = 0;
            var temp = head;
            while (temp != null)
            {
                ans *= 2;
                ans += temp.data;
                temp = temp.next;

            }
            Console.WriteLine("BinaryToDcimal Conversion : " + ans);
        }
        public void Call()
        {
            AddFirst(5);
            AddFirst(6);
            AddFirst(7);
            AddFirst(8);
            Length(head);
            BinaryNumberConversion(head);

        }

    }
}

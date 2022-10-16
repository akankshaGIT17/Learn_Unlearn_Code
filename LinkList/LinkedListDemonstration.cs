using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.LinkList
{
    public class LLNode
    {
        public LLNode next;
        public Object data;
    }

    public class MyLinkedList
    {
        public LLNode head;
        public LLNode getNode(int data)
        {
            // allocate memory for the node
            LLNode newNode = new LLNode();

            // put in the data
            newNode.data = data;
            newNode.next = null;
            return newNode;
        }

       public void printList(LLNode head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
        public void printAllNodes()
        {
            LLNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        //Pushes at the begining
        public LLNode push(LLNode head_ref, int new_data)
        {
            /* allocate node */
            LLNode new_node = new LLNode();

            /* put in the data */
            new_node.data = new_data;

            /* link the old list off the new node */
            new_node.next = (head_ref);

            /* move the head to point to the new node */
            (head_ref) = new_node;

            return head_ref;
        }


        public void AddFirst( LLNode head, Object data)
        {
            LLNode toAdd = new LLNode();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }
        void deleteNode(int position)
        {

            // If linked list is empty
            if (head == null)
                return;

            // Store head node
            LLNode temp = head;

            // If head needs to be removed
            if (position == 0)
            {

                // Change head
                head = temp.next;
                return;
            }

            // Find previous node of the node to be deleted
            for (int i = 0; temp != null && i < position - 1;
                 i++)
                temp = temp.next;

            // If position is more than number of nodes
            if (temp == null || temp.next == null)
                return;

            // Node temp->next is the node to be deleted
            // Store pointer to the next of node to be deleted
            LLNode next = temp.next.next;

            // Unlink the deleted node from list
            temp.next = next;
        }
        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new LLNode();

                head.data = data;
                head.next = null;
            }
            else
            {
                LLNode toAdd = new LLNode();
                toAdd.data = data;

                LLNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

        void caller() {
            LLNode llist = new LLNode();

            AddFirst(head,7);
            AddFirst(head,1);
            AddFirst(head,3);
            AddFirst(head, 2);
            AddFirst(head, 8);

            Console.WriteLine("\nCreated Linked list is: ");
            printAllNodes();

            // Delete node at position 4
            deleteNode(4);

            Console.WriteLine("\nLinked List after "
                              + "Deletion at position 4: ");
            printAllNodes();

            //////////////PRINT AFTER Nth////////////////
            ///
           
        }
    
    }

    public class LinkedListPredefined
    {

        
        // -------------SINGLE LINK LIST------------
        public class LinkListNode
        {
            public int data;
            public LinkListNode next;
            public LinkListNode(int d)
            {
                data = d;
                next = null;
            }
        }
        
        internal class SingleLinkedList
        {
            internal LinkListNode head;
        }
        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            LinkListNode new_node = new LinkListNode(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            LinkListNode new_node = new LinkListNode(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            LinkListNode lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }
        internal void InsertAfter(LinkListNode prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            LinkListNode new_node = new LinkListNode(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        internal LinkListNode GetLastNode(SingleLinkedList singlyList)
        {
            LinkListNode temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)
        {
            LinkListNode temp = singlyList.head;
            LinkListNode prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        // -------------DOUBLY LINK LIST------------
        internal class DNode
        {
            internal int data;
            internal DNode prev;
            internal DNode next;
            public DNode(int d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }
        internal class DoubleLinkedList
        {
            internal DNode head;
        }
        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }
        internal void InsertLast(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DNode GetLastNode(DoubleLinkedList doublyList)
        {
            DNode temp = doublyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void DeleteNodebyKey(DoubleLinkedList doubleLinkedList, int key)
        {
            DNode temp = doubleLinkedList.head;
            if (temp != null && temp.data == key)
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

        // ------------PREDEFINED----------

        LinkedList<string> linkList = new LinkedList<string>();
        public void DefineLinkList()
        {
            linkList.AddFirst("First");
            linkList.AddLast("Second");
            linkList.AddLast("Third");
            linkList.AddLast("Fourth");

            //2 more methods
            //    -AddAfter
            //    - AddBefore
        }

        public void DeleteLinkList()
        {
            linkList.Remove(linkList.First);
            linkList.Remove("Third");
            linkList.RemoveLast();
            linkList.RemoveFirst();
            linkList.Clear();
        }
        public void CheckAvailability()
        {
            linkList.Contains("Fourth");
        }


    }
}

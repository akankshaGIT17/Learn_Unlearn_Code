using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.LinkList
{
    internal class FindAndDetectLoopInLinkedList
    {
        bool DetectLoop(LLNode head)
        {
            // Space complexity : O(n) TC : O(n)
            LLNode temp = head;
            Dictionary<LLNode, bool> visited = new Dictionary<LLNode, bool>();
            while (temp.next != null)
            {
                if (visited.ContainsKey(temp.next))
                {
                    return true;
                }
                visited[temp.next] = true;
                temp = temp.next;
            }
            return false;
        }
        LLNode floyedDetectLoop(LLNode head)
        {
            // SP : O(1) TC: O(n)
            // Detecting a Cycle
            if (head == null)
                return null;
            LLNode slow = head;
            LLNode fast = head;
            while (slow != null && fast != null)
            {
                fast = fast.next;
                if (fast.next != null)
                {
                    fast = fast.next;
                }
                slow = slow.next;
                if (slow == fast)
                {
                    return slow;
                }
            }
            return null;

        }
        LLNode getStartingNode(LLNode head)
        {
            if (head == null)
                return null;
            LLNode slow = head;
            LLNode intersection = floyedDetectLoop(head);
            if(intersection == null)
                return head;
            while (slow != intersection)
            {
                slow = slow.next;
                intersection = intersection.next;
            }
            return slow;
        }

        void removeLoop(LLNode head)
        {
            if (head == null)
                return;
            LLNode startNode = getStartingNode(head);
            LLNode temp = startNode;
            while(temp.next != startNode){
                temp = temp.next;
            }
            temp.next = null;
        }

        bool isCircularLinkList(LLNode head)
        {
            if (head == null)
            {
                return true;
            }
            LLNode temp = head.next;
            while (temp != null && temp != head)
            {
                temp = temp.next;
            }
            if (temp == head)
            {
                return true;
            }
            return false;
        }
    }
}

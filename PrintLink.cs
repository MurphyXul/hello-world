using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLib
{
    public class PrintLink
    {
        public int[] ReversePrint(ListNode head) 
        {
            int linkIndex = 0;
            ListNode listNode = head;
            while (listNode != null) 
            {
                listNode = listNode.next;
                linkIndex++;
            }

            listNode = head;
            int[] resultArr = new int[linkIndex];
            for(int i = linkIndex - 1; i >= 0; i--) 
            {
                resultArr[i] = listNode.val;
                listNode = listNode.next;
            }

            return resultArr;
        }
    }

    public class ListNode
    {
        public int val { get; set; }

        public ListNode next { get; set; }

        public ListNode(int x) 
        {
            val = x;
        }
    }
}

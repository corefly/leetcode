﻿namespace DynamicProgramming;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class MergeTwoSortedLists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode head = null;
        ListNode current = head;

        if (list1.val < list2.val)
        {
            current = new ListNode(list1.val);
            list1 = list1.next;
        }
        else
        {
            current = new ListNode(list2.val);
            list2 = list2.next;
        }

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            }

            current = current.next;
        }

        while (list1 != null)
        {
            current.next = new ListNode(list1.val);
            list1 = list1.next;
            current = current.next;
        }
        
        while (list1 != null)
        {
            current.next = new ListNode(list2.val);
            list2 = list2.next;
            current = current.next;
        }

        return head;
    }
}
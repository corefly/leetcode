namespace DynamicProgramming;
public class RemoveDuplicatesFromSortedList
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        var last = head;
        var cur = head.next;

        while (cur != null)
        {
            if (cur.val == last.val)
            {
                last.next = cur.next;
            }
            else
            {
                last = cur;
            }

            cur = cur.next;
        }

        return head;
    }
}

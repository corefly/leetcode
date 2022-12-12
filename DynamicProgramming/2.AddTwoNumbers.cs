using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DynamicProgramming
{
	public class AddTwoNumbers
	{
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

		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = ListNode(0);
            var current = result;
            var carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                var x = l1 != null ? l1.val : 0;
                var y = l2 != null ? l2.val : 0;
                var sum = x + y + carry;

                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            return result.next;
        }
	}
}

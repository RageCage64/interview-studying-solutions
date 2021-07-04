using System;

namespace Interviews.LL {
	public static class Remove {
		public static LNode	RemoveKth(LNode head, int k) {
			if(head.Length() < k) 
				return head;

			if(head.Length() == k) 
				return head.Next;

			LNode prev = head;
			LNode curr = head.Next;
			while(curr.Length() != k) {
				prev = prev.Next;
				curr = curr.Next;
			}
			prev.Next = curr.Next;

			return head;
		}

		public static LNode EfficientRemoveKth(LNode head, int k) {
			RecursiveRemoveKthNode(head, k);	
			return head;
		}

		private static int RecursiveRemoveKthNode(LNode head, int current) {
			if(head.Next == null)
				return current - 1;

			current = RecursiveRemoveKthNode(head.Next, current);
			if(current == 0) 
				head.Next = head.Next.Next;	

			return current - 1;
		}
	}
}

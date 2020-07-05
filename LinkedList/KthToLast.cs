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
	}
}

namespace Interviews.LL {
	public static class LLUtilities {
		public static LNode BuildLinkedList(int n) {
			LNode head = null;
			LNode iter = null;

			for(int i = 1; i <= n; i++) {
				var newNode = new LNode { Data = i, Next = null };
				if(head == null) {
					head = newNode;
					iter = head;
				} else {
					iter.Next = newNode;
					iter = iter.Next;
				}
			}
			
			return head;
		}
	}
}

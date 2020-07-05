namespace Interviews.LL {
	public class LNode {
		public int Data { get; set; }
		public LNode Next { get; set; }

		public int Length() {
			int length = 1;
			LNode iter = this.Next;		
			while(iter != null) {
				length++;
				iter = iter.Next;
			}
			return length;
		}

		public override string ToString() {
			string result = "";
			LNode iter = this;		
			while(iter != null) {
				result += $"{iter.Data} -> ";
				iter = iter.Next;
			}
			return result;
		}
	}
}

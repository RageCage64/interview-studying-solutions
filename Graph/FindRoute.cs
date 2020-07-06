using System.Collections.Generic;

namespace Interviews.Graph {
	public static class FindRoute {
		public static bool FindRouteBetween(Node src, Node dest) {
			var visitQueue = new Queue<Node>();
			src.Marked = true;
			visitQueue.Enqueue(src);
			
			while(visitQueue.TryDequeue(out Node current)) {
				if(current.Name == dest.Name) 
					return true;

				foreach(Node n in current.Children) {
					if(!n.Marked) {
						if(n.Name == dest.Name) 
							return true;

						n.Marked = true;
						visitQueue.Enqueue(n);
					}
				}
			}

			return false;
		}
	}
}

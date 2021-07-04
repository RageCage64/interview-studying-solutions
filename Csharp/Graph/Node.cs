using System.Collections.Generic;

namespace Interviews.Graph {
	public class Node {
		public string Name { get; set; }
		public List<Node> Children { get; set; }
		public bool Marked { get; set; }

		public Node(string name) {
			Name = name;
			Children = new List<Node>();
			Marked = false;
		}
	}
}

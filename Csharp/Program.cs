using System;
using System.Collections.Generic;

using Interviews.Strings;
using Interviews.LL;
using Interviews.Graph;

namespace Interviews {
    class Program {
        static void Main(string[] args) {
			TestIsUnique();
			Console.WriteLine("------------");
			TestPermutation();
			Console.WriteLine("------------");
			TestRemoveKth();
			Console.WriteLine("------------");
			TestEfficientRemoveKth();
			Console.WriteLine("------------");
			TestRouteBetween();
        }

		static void TestIsUnique() {
			Console.WriteLine("Unique:");

            Console.WriteLine(Unique.IsUnique("test"));
            Console.WriteLine(Unique.IsUnique("tes"));
		}

		static void TestPermutation() {
			Console.WriteLine("Permutation:");

            Console.WriteLine(Permutation.ArePermutations("test", "ttse"));
            Console.WriteLine(Permutation.ArePermutations("tes", "test"));
            Console.WriteLine(Permutation.ArePermutations("test", "tttt"));
		}

		static void TestRemoveKth() {
			Console.WriteLine("Remove Kth:");

			LNode list = LLUtilities.BuildLinkedList(6);
			Console.WriteLine($"Before: {list.ToString()}");
			list = Remove.RemoveKth(list, 4);
			Console.WriteLine($"After: {list.ToString()}");
		}

		static void TestEfficientRemoveKth() {
			Console.WriteLine("Efficient Remove Kth:");

			LNode list = LLUtilities.BuildLinkedList(6);
			Console.WriteLine($"Before: {list.ToString()}");
			list = Remove.EfficientRemoveKth(list, 4);
			Console.WriteLine($"After: {list.ToString()}");
		}

		static void TestRouteBetween() {
			Console.WriteLine("Route Between");

			var src = new Node("a");
			var dest = new Node("b");
			src.Children = new List<Node> {
				new Node("c"),
				new Node("d"),
				new Node("e")
			};
			var inter = new Node("f");
			inter.Children.Add(dest);
			src.Children.Add(inter);

			Console.WriteLine(FindRoute.FindRouteBetween(src, dest));
		}
    }
}

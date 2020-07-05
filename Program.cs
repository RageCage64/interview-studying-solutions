using System;
using Interviews.Strings;
using Interviews.LL;

namespace Interviews {
    class Program {
        static void Main(string[] args) {
			TestIsUnique();
			Console.WriteLine("------------");
			TestPermutation();
			Console.WriteLine("------------");
			TestRemoveKth();
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
    }
}

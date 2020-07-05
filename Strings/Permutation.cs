using System.Linq;

namespace Interviews.Strings {
	class Permutation {
		public static char[] SortCharacters(string s) =>
			s.Select(c => c)
			 .OrderBy(c => c)
			 .ToArray();

		public static bool ArePermutations(string lhs, string rhs) {
			char[] leftSorted = SortCharacters(lhs);
			char[] rightSorted = SortCharacters(rhs);

			if(leftSorted.Length != rightSorted.Length) 
				return false;

			for(int i = 0; i < leftSorted.Length; i++) {
				if(leftSorted[i] != rightSorted[i])
					return false;
			}

			return true;
		}
	}
}

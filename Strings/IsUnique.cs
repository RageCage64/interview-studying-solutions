using System.Linq;

namespace Interviews.Strings {
	class Unique {
		// My solution
		public static bool IsUnique(string s) {
			char[] individualCharacters = 
				s.Select(c => c)
				 .OrderBy(c => c)
				 .ToArray();
			char last = individualCharacters[0];
			for(int i = 1; i < individualCharacters.Length; i++) {
				if(individualCharacters[i] == last) {
					return false;
				}
				last = individualCharacters[i];
			}
			return true;
		}
	}
}

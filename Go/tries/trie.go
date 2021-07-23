package tries

type TrieNode struct {
	Value rune
	Next  []*TrieNode
}

func NewTrieNode(value rune) *TrieNode {
	return &TrieNode{
		Value: value,
		Next:  make([]*TrieNode, 0),
	}
}

func NewTrie() *TrieNode {
	return NewTrieNode(' ')
}

func (n *TrieNode) InsertNext(value rune) {
	n.Next = append(n.Next, NewTrieNode(value))
}

func (n *TrieNode) Terminate() {
	n.Next = append(n.Next, NewTrieNode('*'))
}

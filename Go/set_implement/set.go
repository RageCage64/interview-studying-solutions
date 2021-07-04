package main

import "fmt"

type StringSet map[string]struct{}

func (set StringSet) Add(s string) {
	set[s] = struct{}{}
}

func (set StringSet) Contains(s string) bool {
	_, ok := set[s]
	return ok
}

func (set StringSet) Remove(s string) {
	delete(set, s)
}

func main() {
	set := make(StringSet)
	set.Add("f")
	fmt.Println(set.Contains("f"))
	set.Remove("f")
	fmt.Println(set.Contains("f"))
}

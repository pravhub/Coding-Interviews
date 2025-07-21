class Trie:

    def __init__(self):
        self.eow = False
        self.items = [None]*26
        

    def insert(self, word: str) -> None:
        idx = ord(word[0])-ord('a')
        if not self.items[idx]:
            self.items[idx] = Trie()
        if len(word) > 1:
            self.items[idx].insert(word[1:])
        else:
            self.items[idx].eow = True

    def search(self, word: str) -> bool:
        idx = ord(word[0])-ord('a')
        if not self.items[idx]:
            return False
        else:
            if len(word) == 1:
                return self.items[idx].eow
            else:
                return self.items[idx].search(word[1:]) 

    def startsWith(self, prefix: str) -> bool:
        idx = ord(prefix[0])-ord('a')
        if not self.items[idx]:
            return False
        else:
            if len(prefix) == 1:
                return True
            else:
                return self.items[idx].startsWith(prefix[1:])



# Your Trie object will be instantiated and called as such:
# obj = Trie()
# obj.insert(word)
# param_2 = obj.search(word)
# param_3 = obj.startsWith(prefix)

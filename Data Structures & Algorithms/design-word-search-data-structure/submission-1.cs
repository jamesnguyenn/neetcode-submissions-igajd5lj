public class WordDictionary {
    public TrieNode root;

    public WordDictionary() {
        this.root = new TrieNode();
    }
    
    public void AddWord(string word) {
        var dummy = root;
        foreach(var c in word)
        {
            if(!dummy.Children.ContainsKey(c))
                dummy.Children[c] = new TrieNode();
            dummy = dummy.Children[c];
        }
        dummy.IsEnd = true;
    }
    
    public bool Search(string word) {   
        var node = root;
      
        return DFS(word, 0, node);
    }
    public bool DFS(string word, int index, TrieNode node)
    {
            if(index == word.Length)
            return node.IsEnd;
            var c = word[index];
            if(c == '.'){
                foreach(var child in node.Children.Values){
                    if(DFS(word, index + 1,child))
                        return true;
                }
            }else{
                if(!node.Children.ContainsKey(c))
                    return false;
                return DFS(word, index + 1, node.Children[c]);
            }
        return false;
    }
}

public class TrieNode {
     public Dictionary<char,TrieNode> Children = new();
     public bool IsEnd = false;
}

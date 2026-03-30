public class PrefixTree {
    private TrieNode root ;

    public PrefixTree() {
        if(this.root == null)
        {
            this.root = new TrieNode();
        }
    }
    
    public void Insert(string word) {
        var dummy = root;
        foreach(var item in word)
        {
            if(!dummy.Children.ContainsKey(item))
            {
                dummy.Children[item] = new TrieNode();
            }
            dummy = dummy.Children[item];
        }
        dummy.IsEnd  = true;
    }
    
    public bool Search(string word) {
        var dummy = root;
        foreach(var item in word)
        {
            if(!dummy.Children.ContainsKey(item))
            {
                return false;
            }
            dummy = dummy.Children[item];
        }
        return dummy.IsEnd;
        
    }
    
    public bool StartsWith(string prefix) {
         var dummy = root;
        foreach(var item in prefix)
        {
            if(!dummy.Children.ContainsKey(item))
            {
                return false;
            }
            dummy = dummy.Children[item];
        }
        return true;
    }
}

public class TrieNode {
    public Dictionary<char, TrieNode> Children =  new();
    public bool IsEnd = false;
}
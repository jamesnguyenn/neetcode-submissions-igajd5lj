public class Solution {
    public class TrieNode {
        public Dictionary<char, TrieNode> Children = new();
        public bool IsEnd = false;
    }
    public class Trie {
        public TrieNode root = new TrieNode();

        public Trie()
        {}
        public void Add(string words)
        {
            var node = root;
            foreach(var c in words)
            {
                if(!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();
                node = node.Children[c];
            }
            node.IsEnd = true;
        }
        public bool Search(string words)
        {
            var node = root;
            foreach(var c in words)
            {
                if(!node.Children.ContainsKey(c)) return false;
                node = node.Children[c];
            }
            return node.IsEnd;
        }
    }
    public bool WordBreak(string s, List<string> wordDict) {
            var trie = new Trie();
            foreach(var item in wordDict)
            {
                trie.Add(item);
            }
            var dp = new bool[s.Length];
            for(var i  = 0; i < s.Length ; i++)
            {
                for(var j = 0; j <= i; j++)
                {
                    var subString = s.Substring(j,  i - j + 1);
                    if(trie.Search(subString) && (j == 0 || dp[j - 1]))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length - 1];

    }
}

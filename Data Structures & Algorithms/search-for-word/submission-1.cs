public class Solution {
    public bool Exist(char[][] board, string word) {
        var trie = new Trie();
        trie.Add(word);

        for(var r = 0; r < board.Length; r++)
        {
            for(var c = 0; c < board[0].Length; c++)
            {
                if(trie.root.Children.ContainsKey(board[r][c]) && DFS(r, c, trie.root, board))
                {
                    return true;
                }
            }
        }

        return false;

    }

    public bool DFS(int r, int c, TrieNode node, char[][] board)
    {

        if(r < 0 || c < 0 || r >= board.Length || c >= board[0].Length)
        {
             return false;
        }
        
        var temp = board[r][c];

        if(temp == '#' || !node.Children.ContainsKey(temp)){
            return false;
        }
        node = node.Children[temp];
        if(node.IsEnd) return true;
       
        board[r][c] = '#';
        var found = DFS(r + 1, c,node, board) || 
                    DFS(r - 1, c,node, board) || 
                    DFS(r, c + 1,node, board) || 
                    DFS(r, c - 1,node, board);

        board[r][c] = temp;

        return found;
    }


    public class TrieNode {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public bool IsEnd = false;
    }

    public class Trie {
        public TrieNode root ;
        public Trie()
        {
            this.root = new TrieNode();
        }
        public void Add(string word)
        {
            var node = this.root;
            foreach(var item in word)
            {
                if(!node.Children.ContainsKey(item))
                    node.Children[item] = new TrieNode();
                node = node.Children[item];
            }
            node.IsEnd =true;
        }
        
    }
}

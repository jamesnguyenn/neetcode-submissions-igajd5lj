public class Solution {
    public List<string> FindWords(char[][] board, string[] words) {
        var root = new Trie();
        var result = new List<string>();
        foreach(var item in words)
        {
            root.Add(item);
        }

        for(var r = 0; r < board.Length ; r++)
        {
            for(var c = 0; c < board[0].Length; c++)
            {
                DFS(r,c, board, root.root, result);
            }
        }
        return result;
        
    }

    public void DFS(int r, int c, char[][]board, TrieNode node, List<string> result)
    {
        if( r < 0 || r >= board.Length || c < 0 || c >= board[0].Length || board[r][c] == '*' ) return;
        var temp = board[r][c];
        if(!node.Children.ContainsKey(temp)){
            return;
        }
        node = node.Children[temp]; 
        board[r][c] = '*';
        if(node.IsEnd)
        {
            result.Add(node.Word);
            node.IsEnd = false;
        }

        DFS(r + 1,c, board, node, result);
        DFS(r - 1,c, board, node, result);
        DFS(r , c + 1, board, node, result);
        DFS(r , c - 1, board, node, result);
        board[r][c] = temp;

    }

    public class TrieNode{
        public Dictionary<char, TrieNode> Children = new ();
        public bool IsEnd = false;
        public string Word = null;
    }

    public class Trie {
        public TrieNode root;
        public Trie (){
            this.root = new TrieNode();
        }

        public void Add(string words){
            var node = root;
            foreach(var item in words){
                if(!node.Children.ContainsKey(item))
                    node.Children[item] = new TrieNode();
                node = node.Children[item];
            }
            node.Word = words; 
            node.IsEnd = true;
        }
        public bool Search(string words)
        {
            var node =root;
            foreach(var item in words)
            {
                if(!node.Children.ContainsKey(item))
                    return false;
                node = node.Children[item];
            }
            return true;
        }
    }
}

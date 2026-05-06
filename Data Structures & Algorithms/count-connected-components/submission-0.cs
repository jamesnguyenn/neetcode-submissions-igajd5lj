public class Solution {
    public int count = 0;
    public int CountComponents(int n, int[][] edges) {
        Dictionary<int, List<int>> graph = new();

        for(var i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
        }
        foreach(var node in edges)
        {
            graph[node[0]].Add(node[1]);
            graph[node[1]].Add(node[0]);
        }

        HashSet<int> visited = new();
        for(var i = 0; i < n; i++)
        {
            if(!visited.Contains(i))
            {
                DFS(i, visited, graph);
                count++;
            }
        }
        return count;
        
    }

    public void DFS(int node, HashSet<int> visited,  Dictionary<int, List<int>> graph)
    {
        if(visited.Contains(node)) return;
        visited.Add(node);
        foreach(var n in graph[node])
        {
            DFS(n, visited, graph);
        }
    }
}

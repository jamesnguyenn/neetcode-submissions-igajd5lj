public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        Dictionary<int, List<int>> graph = new();
        for(var i = 0; i < n; i++)
        {   
            graph.Add(i, new List<int>());
        }
        foreach(var item in edges)
        {
            graph[item[0]].Add(item[1]);
            graph[item[1]].Add(item[0]);
        }
        HashSet<int> visited = new();
        if(HasCycle(0,-1, visited, graph)) return false;
        
        return visited.Count == n;
    }
    public bool HasCycle(int node, int parent, HashSet<int> visited, Dictionary<int, List<int>> graph)
    {
        if(visited.Contains(node)) return true;
        visited.Add(node);
        foreach(var n in graph[node])
        {
            if(n == parent) continue;
            if(HasCycle(n, node, visited, graph))
                return true;
        }
        
        return false;
    }
}

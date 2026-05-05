public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> graph = new();

        for(var i = 0; i < numCourses; i++)
        {
            graph[i] = new List<int>();
        }
        foreach(var item in prerequisites){
            graph[item[1]].Add(item[0]);
        }

        int[] visited = new int[numCourses];
        for(var i = 0; i < numCourses; i++)
        {
            visited[i] = 0;
        }

        for(var i = 0; i < numCourses; i++)
        {
            if(HasCycle(i, visited, graph)) return false;
        }   
        return true;
    }
    public bool HasCycle(int i,  int[] visited,  Dictionary<int, List<int>> graph )
    {
        if(visited[i] == 1) return true;
        if(visited[i] == 2) return false;

        visited[i] = 1;

        foreach(var n in graph[i])
        {
            if(HasCycle(n, visited, graph))
                return true;
        }
        visited[i] = 2;

        return false;
    }
}

//0: chưa thăm
//1: đang thăm
//2: đã thăm
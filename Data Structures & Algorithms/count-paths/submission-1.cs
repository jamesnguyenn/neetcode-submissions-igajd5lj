public class Solution {
    private int[,] cache ;
    public int UniquePaths(int m, int n) {
        cache = new int[m, n];
        return DFS(0,0,m,n);
    }
    public int DFS(int i, int j, int m, int n)
    {
        if(i >= m || j >= n) return 0;
        if(i == m - 1 || j == n - 1) return 1;
        if(cache[i,j] != 0) return cache[i,j];
        cache[i,j] = DFS(i, j + 1,m,n) + DFS(i + 1, j,m,n);
        return cache[i,j];
    }
}

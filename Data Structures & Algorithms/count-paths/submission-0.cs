public class Solution {
    public int UniquePaths(int m, int n) {
        return DFS(0,0,m,n);
    }
    public int DFS(int i, int j, int m, int n)
    {
        if(i >= m || j >= n) return 0;
        if(i == m - 1 || j == n - 1) return 1;

        var right = DFS(i, j + 1,m,n);
        var bottom = DFS(i + 1, j,m,n);

        return right + bottom;
    }
}

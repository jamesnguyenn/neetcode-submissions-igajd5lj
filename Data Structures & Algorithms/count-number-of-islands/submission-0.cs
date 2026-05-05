public class Solution {
    public int NumIslands(char[][] grid) {
        var count = 0;
        for(var i = 0; i < grid.Length; i++)
        {
            for(var j= 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    count++;
                    DFS(i,j, grid);
                }
            }
        }
        return count;
    }
    public void DFS(int i, int j, char[][] grid)
    {
        if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) return;
        if(grid[i][j] == '0') return;
        grid[i][j] = '0';
        DFS(i + 1, j, grid); 
        DFS(i - 1, j, grid); 
        DFS(i, j+1, grid);
        DFS(i, j-1, grid);
    }
}

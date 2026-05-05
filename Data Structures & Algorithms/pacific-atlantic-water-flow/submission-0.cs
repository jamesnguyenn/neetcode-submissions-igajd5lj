public class Solution {
    int[][] dirs = new int[][]
    {
        new int[]{1,0},
        new int[]{-1,0},
        new int[]{0,1},
        new int[]{0,-1}
    };
    public List<List<int>> PacificAtlantic(int[][] heights) {
        var result = new List<List<int>>();
        if(heights.Length <= 0) return result;
        int m = heights.Length;
        int n = heights[0].Length;
        bool[,] pacific = new bool[m,n];
        bool[,] atlantic = new bool[m,n];

        for(var i = 0;  i < n; i++)
        {
            DFS(pacific, 0,i,heights);
        }
        for(var j = 0; j < m; j++)
        {
            DFS(pacific, j,0,heights);
        }

        for(var i = 0;  i < n; i++)
        {
            DFS(atlantic,m - 1,i,heights);
        }
        for(var j = 0; j < m ; j++)
        {
            DFS(atlantic, j,n-1,heights);
        }

        for(var i = 0; i < m; i++)
        {
            for(var j = 0; j < n; j++)
            {
                if(pacific[i,j] == true && atlantic[i,j] == true)
                {
                    result.Add(new List<int>(){i,j});
                }
            }
        }
        return result;
    }

    public void DFS(bool[,] ocean, int i, int j, int[][] heights)
    {
        if(ocean[i,j]) return;
        ocean[i,j] = true;
        foreach(var dir in dirs)
        {
            var x = i + dir[0];
            var y = j + dir[1];
            if(x >= 0 && y >= 0 && x < heights.Length && y < heights[0].Length && heights[x][y] >= heights[i][j])
            {
                DFS(ocean, x, y, heights);
            }
        }
    }
}

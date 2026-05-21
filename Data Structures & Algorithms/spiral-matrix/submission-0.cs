public class Solution {
    public List<int> result = new List<int>();
    public List<int> SpiralOrder(int[][] matrix) {
        var t = 0;
        var l = 0;
        var r = matrix[0].Length - 1;
        var b = matrix.Length -1;

        while(t <= b && l <= r)
        {
            for(var i = l; i <= r;i++)
            {
                    result.Add(matrix[t][i]);
            }
            t++;

            for(var i = t; i <= b;i++)
            {
                result.Add(matrix[i][r]);
            }
            r--;

            if(t <= b)
            {
                for(var i = r; i >= l; i--)
                {
                    result.Add(matrix[b][i]);
                }
                b--;
            }

            if(l <= r)
            {
                for(var i = b; i >= t; i--)
                {
                    result.Add(matrix[i][l]);
                }
                l++;
            }
        }

        return result;
    }
}

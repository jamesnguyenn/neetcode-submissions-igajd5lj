public class Solution {
    public void SetZeroes(int[][] matrix) {
        var rLength = matrix.Length;
        var cLength = matrix[0].Length;
        var first = false;

        for(var r= 0; r < rLength; r++)
        {
            for(var c = 0; c < cLength; c++)
            {
                if(matrix[r][c] == 0)
                {
                    matrix[0][c] = 0;
                    if(r > 0)
                    {
                       matrix[r][0] = 0;
                    }else{
                        first = true;
                    }
                }
            }
        }

        for(var r = 1; r < rLength; r++)
        {
            for(var c = 1; c < cLength; c++)
            {
                if(matrix[0][c] == 0 || matrix[r][0] == 0)
                {
                    matrix[r][c] = 0;
                }
            } 
        }

        if(matrix[0][0] == 0)
        {
            for(var r = 0; r< rLength;r++)
            {
                matrix[r][0] = 0;
            }
        }
        if(first)
        {
            for(var c = 0; c < cLength;c++)
            {
                matrix[0][c] = 0;
            }
        }
    }
}

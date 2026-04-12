public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n+1];

        for(var i=0; i<= n ; i++)
        {
           var count = int.PopCount(i);
           result[i] = count;
        }
        return result;
    }
}

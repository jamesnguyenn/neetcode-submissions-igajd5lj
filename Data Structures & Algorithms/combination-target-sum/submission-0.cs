public class Solution {

    public List<List<int>> res = new List<List<int>>();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);
        this.BackTracking(0, new List<int>(), 0, nums,target);
        return res;
    }

    private void BackTracking(int i, List<int> curr,int total, int[] nums, int target){
       if(total == target)
       {
            res.Add(new List<int>(curr));
            return;
       }
       for(var j = i; j < nums.Length; j++)
       {
            if(total + nums[j] > target)
            {
                return;
            }
            curr.Add(nums[j]);
            this.BackTracking(j, curr,total + nums[j], nums, target);
            curr.RemoveAt(curr.Count - 1);
       }
    }
}

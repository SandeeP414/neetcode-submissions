public class Solution {
    public int[] TwoSum(int[] nums, int target) { 
        int[] twoNums = new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=1;j<nums.Length;j++)
            {
                if(nums[i] + nums[j] == target && i != j)
                {
                    twoNums[0] = i;
                    twoNums[1] = j;
                    return twoNums;
                }
            }
                
        }
        return twoNums;
    }
}

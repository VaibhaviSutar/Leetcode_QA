public class Solution {
    public int MissingNumber(int[] nums) {
        int totalSum=nums.Length * (nums.Length + 1)/2;
        int actualSum=0;
        for(int i=0;i<nums.Length;i++)
        {
           actualSum+=nums[i];
        }
        return totalSum-actualSum;

    }
}
public class Solution {
    public int MaxSubArray(int[] nums) {
        int CurrSum=0; int MaxSum=int.MinValue;
        for(int i=0;i<nums.Length;i++)
        {
            CurrSum+=nums[i];
            MaxSum=Math.Max(CurrSum,MaxSum);
            if(CurrSum<0)
            {
                CurrSum=0;
            }
        }

        return MaxSum;
    }
}
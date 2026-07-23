public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        bool result=false;
        HashSet<int> map = new HashSet<int>();
        foreach(var num in nums)
        {
            if(!map.Contains(num))
            {
                map.Add(num);
            }
            else
            {
                result = true;
            }
        }
        return result;
    }
}
public class Solution {
    public bool IsPalindrome(int x) {
       if(x<0) return false;
       int temp=x;
       int result=0;
       while(temp!=0)
       {
            int val = temp %10;
            result=result * 10 + val;
            temp/=10;
       }
       return x==result;
    }
}
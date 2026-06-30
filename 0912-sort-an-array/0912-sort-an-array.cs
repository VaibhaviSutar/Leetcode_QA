public class Solution {
    public int[] SortArray(int[] nums) 
    {
        MergeSort(nums,0,nums.Length-1);
        return nums;
    }

    public void MergeSort(int[] arr, int st, int end)
    {
        if(st<end)
        {
            int mid = st + (end-st)/2;
            MergeSort(arr,st,mid);
            MergeSort(arr,mid+1,end);
            Merge(arr,st,mid,end);
        }
    }

    public void Merge(int[] arr,int st,int mid,int end)
    {
        List<int> temp = new List<int>();;
        int i=st;int j=mid +1;
        while(i<=mid && j<=end)
        {
            if(arr[i]<=arr[j])
            {
                temp.Add(arr[i]);
                i++;
            }
            else
            {
                temp.Add(arr[j]);
                j++;
            }
        }
        while(i<=mid)
        {
            temp.Add(arr[i]);
            i++;
        }
        while(j<=end)
        {
            temp.Add(arr[j]);
            j++;
        }
        for(int index=0;index<temp.Count;index++)
        {
            arr[index+st]=temp[index];
        }
    }
}
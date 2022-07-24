public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        var concatList = nums1.Concat(nums2).ToArray();
        Array.Sort(concatList);
        if (concatList.Count() % 2 != 0) return (double)concatList[concatList.Count() / 2];
        else return (double)(concatList[concatList.Count() / 2] + concatList[(concatList.Count() / 2) - 1]) / 2;

    }
        
}
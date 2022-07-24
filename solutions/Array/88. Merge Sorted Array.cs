public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        Int32 l = m + n - 1;
        while(n > 0 && m > 0){
            if(nums1[m-1] > nums2[n-1]){
                nums1[l] = nums1[m-1];
                m--;
            }
            else{
                nums1[l] = nums2[n-1];
                n--;
            }
            l--;
        }
        while(n > 0){
            nums1[l] = nums2[n-1];
            n--;
            l--;
        }
        
    }
}
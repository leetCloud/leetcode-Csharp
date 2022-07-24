public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        else if (nums.Length == 1) return 1;      
        int buff = nums[0];
        int count = 1;
        
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] != buff) {
                nums[count++] = nums[i];
                buff = nums[i];             
            }
            
        return count;
    }
}
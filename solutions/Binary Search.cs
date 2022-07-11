public class Solution {
    public int Search(int[] nums, int target) {
            if (nums.Length < 1) return -1;
            return nums.ToList().FindIndex(x => x == target);        
    }
} 
public class Solution {
    public int Search(int[] nums, int target) {
        int r =  nums.Length-1;
        int l = 0;

        while(r>=l)
        {
            int mid = l+(r-l)/2;
            if(nums[mid] == target) return mid;
            else if(nums[mid] <target) l = mid +1;
            else r = mid - 1;
        }
        return -1;
    }
}   
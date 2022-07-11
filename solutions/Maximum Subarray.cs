public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if (nums == null)
            return 0;

        int ans = nums[0];
        int interval = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            interval += nums[i];
            ans = Math.Max(interval, ans);

            interval = Math.Max(0, interval);
        }
        return ans;
    }
}
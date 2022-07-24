public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
            var copyOf = nums;
            var rs = nums.Concat(copyOf).ToArray();
            return rs;
    }
}
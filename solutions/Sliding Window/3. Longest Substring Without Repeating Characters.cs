public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0, rs = 0;
        HashSet<char> hs = new HashSet<char>();
        for(int right = 0; right < s.Length; right++){
            while(hs.Contains(s[right])){
                hs.Remove(s[l]);
                l++;
            }
            hs.Add(s[right]);
            rs = Math.Max(right - l + 1, rs);
        }
        return rs;
    }
}
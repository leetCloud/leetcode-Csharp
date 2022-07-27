public class Solution {
    public int CountGoodSubstrings(string s) {
        if(s == null || s.Length < 3) return 0;
        int rs = 0;
        for(int i = 0; i< s.Length -2; i++){
            if(s[i] != s[i+1] && s[i] != s[i+2] && s[i+1] != s[i+2]){
                rs++;
            }
        }
        return rs;
    }
}
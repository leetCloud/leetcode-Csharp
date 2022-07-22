public class Solution {
    public char NextGreatestLetter(char[] letters, char target) 
    {
        if(target >= letters[letters.Length -1]) return letters[0];
        int l = 0, r = letters.Length - 1;
        while(l < r){
            int m = l + (r - l)/2;
            if(letters[m] <= target){
               l = m+1;
            }
            else  r = m;
        }
        return letters[l];
    }
}
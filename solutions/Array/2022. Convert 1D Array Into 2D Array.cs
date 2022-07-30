public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(m*n != original.Length) return new int[0][];
        int[][]rs = new int[m][];
        int ind = 0;
        for(int i = 0; i < m; i ++){
            rs[i] = new int[n];
            for(int j = 0; j < n; j++){
                rs[i][j] = original[ind++];
            }
        }
        return rs;
    }
}
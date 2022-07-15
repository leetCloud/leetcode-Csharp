blic class Solution {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int r, l;
            foreach(int[] row in matrix)
            {
                
                r = row.Length - 1;
                l = 0;
                while(r>=l)
                {
                    int m = (r + l)/2;
                    if(row[m] == target) return true;
                    else if (row[m]> target)
                    {
                        r = m-1;
                    }
                    else if(row[m] < target)
                    {
                        l = m + 1;
                    }
                }
            }
            return false;
        }
    
}
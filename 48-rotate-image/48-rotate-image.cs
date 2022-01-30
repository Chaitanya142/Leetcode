
class Solution
{
    public void Rotate(int[][] matrix)
    {
        
        int l = 0;
        int r = matrix.Length - 1;

        while (l < r)
        {
            for (int i = 0; i < r - l; i++)
            {
                int t = l;
                int b = r;

                // store top left
                int temp = matrix[t][l + i];

                // move bottom left to top right
                matrix[t][l + i] = matrix[b - i][l];

                // move bottom right to bottom left
                matrix[b - i][l] = matrix[b][r - i];

                // move top right to botom right
                matrix[b][r - i] = matrix[t + i][r];

                // move top left to top right
                matrix[t + i][r] = temp;
            }

            l++;
            r--;
        }
        
    }
}
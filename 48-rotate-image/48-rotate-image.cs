/*
 * clockwise rotate
 * first swap the symmetry (i.e. transpose the matrix), then reverse each row
 * 1 2 3     1 4 7     7 4 1
 * 4 5 6  => 2 5 8  => 8 5 2
 * 7 8 9     3 6 9     9 6 3
 * 
 * anti-clockwise rotate
 * first swap the symmetry (i.e. transpose the matrix), then reverse each col
*/
class Solution
{
    public void Rotate(int[][] matrix)
    {
        int s = 0, e = matrix.Length - 1;
        while (s < e)
        {
            int[] temp = matrix[s];
            matrix[s] = matrix[e];
            matrix[e] = temp;
            s++; e--;
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i + 1; j < matrix[i].Length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
}
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> output = new List<int>();
        int n = matrix.Length;
        if (n == 0)
            return output;
        int m = matrix[0].Length;
        int stage = 1;
        int x = 0, y = 0;
        int maxx = m - 1;
        int maxy = n - 1;
        int minx = 0;
        int miny = 0;

        while (stage != 0)
        {
            switch (stage)
            {
                case 1:
                    if (x < maxx)
                    {
                        output.Add(matrix[y][x]);
                        x++;
                    }
                    else
                    {
                        //output.Add(matrix[y][x]);
                        stage = 2;
                    }
                    break;
                case 2:
                    if (y < maxy)
                    {
                        output.Add(matrix[y][x]);
                        y++;
                    }
                    else
                    {
                        //output.Add(matrix[y][x]);
                        stage = 3;
                    }
                    break;
                case 3:
                    if (x > minx && miny != maxy)
                    {
                        output.Add(matrix[y][x]);
                        x--;
                    }
                    else
                    {
                        //output.Add(matrix[y][x]);
                        stage = 4;
                    }
                    break;
                case 4:
                    if (y > miny && minx != maxx)
                    {
                        output.Add(matrix[y][x]);
                        y--;
                    }
                    else
                    {
                        //output.Add(matrix[y][x]);
                        stage = 1;
                        minx++;
                        miny++;
                        maxx--;
                        maxy--;

                        if (minx > maxx || miny > maxy)
                        {
                            if (output.Count() < m * n)
                                output.Add(matrix[y][x]);
                            stage = 0;
                        }
                        else
                        {
                            x++; y++;
                        }

                    }
                    break;
            }
        }

        return output;
    }
}
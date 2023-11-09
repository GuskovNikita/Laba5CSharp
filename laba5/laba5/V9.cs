using System;
class V9
{
    public static void task9()
    {
        int i, j;
        Random random = new Random();
        int m = random.Next(2, 5);
        int n = random.Next(2, 5);
        int[,] matrix = new int[m,n];
        buildMatrix.build(matrix);
        int[] array = new int[m];
        for (i = 0; i < m; i++)
        {
            int min = matrix[i,0];
            int max = matrix[i,0];
            for (j = 0; j < n; j++)
            {
                if (matrix[i,j] < min)
                {
                    min = matrix[i,j];
                }
                if (matrix[i,j] > max)
                {
                    max = matrix[i,j];
                }
            }
            array[i] = min + max;
        }
        Console.WriteLine(string.Join("\n", array));
    }
}


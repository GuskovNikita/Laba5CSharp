using System;
class V10
{
    public static void task10()
    {
        int i, j;
        Random random = new Random();
        int m = random.Next(2, 5);
        int n = random.Next(2, 5);
        int[,] matrix = new int[m,n];
        buildMatrix.build(matrix);
        int[] temp = new int[m];
        for (i = 1; i < m; i += 2)
        {
            for (j = 0; j < n; j++)
            {
                temp[i] = matrix[i,j];
                matrix[i,j] = matrix[i - 1,j];
                matrix[i - 1,j] = temp[i];
            }
        }
        Console.WriteLine("Измененная матрица:");
        for (i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
        {
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
    }
}


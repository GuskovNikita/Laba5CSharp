using System;
public class V8
{
    public static void task8()
    {
        int i, j;
        Random random = new Random();
        int m = random.Next(2, 5);
        int n = random.Next(2, 5);
        int[,] matrix = new int[m, n];
        buildMatrix.build(matrix);
        int min = matrix[0, 0];
        int max = matrix[0, 0];
        for (i = 0; i < matrix.GetLength(0); i++)
        {
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                if (min > matrix[i, j])
                {
                    min = matrix[i, j];
                }
                else if (max < matrix[i, j])
                {
                    max = matrix[i, j];
                }
            }
        }
        float average = (float)(min + max) / 2;
        Console.WriteLine("Среднее арифметическое максимального и минимального элементов = " + average);
    }
}
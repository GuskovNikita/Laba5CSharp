using System;
public class buildMatrix
{
    static int i, j;
    static Random random = new Random();
    public static void build(int[,] matrix)
    {
        for (i = 0; i < matrix.GetLength(0); i++)
        {
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(10) + 1;
            }
        }
        for (i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
        {
            for (j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
    }
}
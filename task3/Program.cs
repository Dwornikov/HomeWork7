void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Arifm(int[,] matrix){
   
            for (int i = 0; i < matrix.GetLength(1); i++) 
            {
                int temp = 0;
                int arifmt = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    temp += matrix[j, i];
                    arifmt += (matrix[j, i] % 2 == 0) ? 1 : 0;
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)temp/matrix.GetLength(0)}");
                
            }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Arifm(matrix);


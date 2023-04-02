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






Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
System.Console.Write("Введите позицию ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);

if(position[0]<size[0]&&position[1]<size[1])
{
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if(position[0]==i&&position[1]==j){
            System.Console.WriteLine($"Элемент на позиции\n{matrix[i,j]}");
           }
            
        }
        
    }
}
else{
    System.Console.WriteLine("Нет такой позиции");
}
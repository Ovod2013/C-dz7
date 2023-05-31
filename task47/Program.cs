// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(m, n, -10, 19);// Вызов метода GetArray 
// и передача ему количества столбцов, строк, максим и миним границ чисел
PrintArray(array);



double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    Random random = new Random();
    double x = 0d;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            x = random.NextDouble();
            x = x * maxValue + minValue;
            x = x - x % 0.1;
            result[i, j] = x;
            //Console.Write(result[i, j]);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// Задача 50. Напишите программу, 
// которая на вход принимает позиции 
// элемента в двумерном массиве, и 
// возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int stroka = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(stroka, stolb, 0, 9);// Вызов метода GetArray 
// и передача ему количества столбцов, строк, максим и миним границ чисел

int[,] GetArray(int stroka, int stolb, int minValue, int maxValue)
{
    int[,] result = new int[stroka, stolb];
    for (int i = 0; i < stroka; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

PrintArray(array);

void PrintArray(int[,] inArray)
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

Console.Write("Введите номер строки требуемого элемента двумерного массива: ");
int strokaTreb = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца требуемого элемента двумерного массива: ");
int stolbTreb = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Требуется элемент {stolbTreb},{strokaTreb}");

if (stolbTreb>stolb || strokaTreb>stroka) Console.WriteLine("Такого элемента нет!");
else Console.WriteLine($"Требуемый элемент: {array[strokaTreb-1,stolbTreb-1]}");
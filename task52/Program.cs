// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

int[] sredneeArifm = SredneeArifm(stroka, stolb);


int[] SredneeArifm(int stroka, int stolb)
{
    
    double[] sredneeArifm = new double[stolb];
    int[] result = new int[stolb];
    for (int j = 0; j < stolb; j++)
    {
        int summaStolb=0;
    for (int i = 0; i < stroka; i++)
    {
        summaStolb=array[i, j]+summaStolb;
        //result[j] = 0;
       // Console.WriteLine($"сумма столб {summaStolb} i={i} j={j}");
    }
    
    //Console.WriteLine($"среднее арифм столбцов j={j} {summaStolb/stroka} ");
    sredneeArifm[j]=(summaStolb/stroka);

    Console.Write($"{sredneeArifm[j] - sredneeArifm[j] % 0.01}; ");
    }
    return result;
}




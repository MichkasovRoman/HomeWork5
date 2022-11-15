// Задача 41. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввел пользователь.

int[] Row_of_Numbers(int M)
{
    int[] ResultArray = new int[M];
    for (int i = 0; i <= M - 1; i++)
    {
        Console.Write($"Введите {i}-й элемента массива: ");
        ResultArray[i] = int.Parse(Console.ReadLine()!);
    }
    return ResultArray;
}

int Count_of_Positive(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

Console.Clear();

Console.Write("Введите длину массива: ");
int number = int.Parse(Console.ReadLine()!);

int[] Working_Array = Row_of_Numbers(number);
Console.WriteLine($"Полученный массив: [{String.Join(", ", Working_Array)}]");

int a = Count_of_Positive(Working_Array);
Console.Write($"Количество элементов, больших нуля, равно {a}.");
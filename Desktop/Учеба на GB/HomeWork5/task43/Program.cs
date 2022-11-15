// задача 43. Напишите программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y = k1*x + b1, y = k2*x + b2.

int[] EquationLine1 ()
{
    int[] equation = new int[2];
    for (int i = 0; i <= 1; i++)
    {
        Console.Write($"Введите угловой коэффийиент первой прямой: ");
        ResultArray[i] = int.Parse(Console.ReadLine()!);
    }
    return ResultArray;
}

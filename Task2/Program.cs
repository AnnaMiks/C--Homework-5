// // Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len = 7)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}
int SumElement(int[] array)
{
int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result = result + array[i];
    }
    return result;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}
int[] array = GenerateArray();
PrintArray(array);
int result = SumElement(array);
Console.Write($"Сумма элементов на нечетных позициях равна + {result}");

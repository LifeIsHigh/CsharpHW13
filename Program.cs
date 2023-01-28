//Задача № 29 -->   Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран

Console.Write("Enter the length of the array --> ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Length];

void RandomArray(int[] array)
{
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
RandomArray(array);
// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
using static System.Console;
Clear();
Write("Задайте количество элементов массива: - ");
int n = int.Parse(ReadLine());
Write("Задайте минимальный ие элементов массива: - ");
int min = int.Parse(ReadLine());
Write("Задайте максимальный из элементов массива: - ");
int max = int.Parse(ReadLine());
int [] collection = new int [n];
FillArray ( collection, min, max);
Write ("[");
PrintArray(collection);
Write ("]");
WriteLine();



// задать массив
void FillArray(int [] array, int min, int max)
{
    for (int i =0; i <array.Length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
}

// печать массива
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}");
        if (i < array.Length -1) Write(",");
    }
}
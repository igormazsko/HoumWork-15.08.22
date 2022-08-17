// Задача 25. Напишите цикл, который нринимает на ввод два числа (А и В) и возводит число А в натуральную степень В.
using static System.Console;
Clear();
Write("Введите число А - ");
int a = int.Parse(ReadLine());
Write("Введите число В - ");
int b = int.Parse(ReadLine());
WriteLine ($"Число {a} в степени {b} равно {DigreeOfNumber(a, b)}");


int DigreeOfNumber (int a, int b)
{
    int n = 1;
    for(int i = 0; i < b; i++)
    {
       n = n * a;
    }
    return n;
}

// Задача 27. Напишите программу которая принимает на вход число и выдаёт сумму цифр в числе
using static System.Console;
Clear();
Write("Введите число А - ");
int a = int.Parse(ReadLine());
WriteLine ($"Сумма чисел числа {a} равна {SumDigitsNamber(a)}");




int SumDigitsNamber(int n)
{
    int result = 0;
    while(n > 0)
    {
        result = n%10 + result;
        n = n / 10;
    }
    return result;
}
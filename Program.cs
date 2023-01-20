// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int Natural(int num)
// {
//     if (num == 1)
//     { return 1; }
//     Console.Write($"{num}, ");
//     return Natural(num - 1);
// }
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = Natural(N);
// Console.WriteLine(x);

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumInterval(int M, int N)
{
if(M == N)
{return N;}

return M + SumInterval(M+1,N);
}

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int x = SumInterval (M,N);
Console.WriteLine(x);

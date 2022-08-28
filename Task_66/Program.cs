
// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте число M: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число N: ");
int m = Convert.ToInt32(Console.ReadLine());

void SumNaturElem(int n, int m)
{
    int sum = 0;

    if (m < n) return;
    for (int i = n; i <= m; i++)
    {
        sum += i;
    }
    System.Console.WriteLine();
    Console.Write($"Сумма элементов от {n} до {m} -> {sum}");
}
SumNaturElem(n, m);
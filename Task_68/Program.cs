// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
// функция Аккермана

Console.Write("Задайте неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

{ 
  int A(int n,int m)
  {
    if (n == 0)
      return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
      else
        return A(n - 1, A(n, m - 1));
  }
  Console.WriteLine();
  Console.WriteLine($"Результат вычисления: {A(m,n)}" );
}


// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int n = ReadData("Введите число N  ");
int m = ReadData("Введите число M  ");
int AkkRec(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkRec(n - 1, 1);
    else
      return AkkRec(n - 1, AkkRec(n, m - 1));
}
Console.WriteLine($"Функция Аккермана чисел {n} и {m} равна:  {AkkRec(n,m)} ");
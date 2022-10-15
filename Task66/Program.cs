// // Задача 66: Задайте значения M и N.
//  Напишите программу,которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int n = ReadData("Введите число N  ");
int m = ReadData("Введите число M  ");
int SumRec(int n, int m)
{
    if (n == m-1) return n+m;
    else return n + SumRec(n+1,m);
}
Console.WriteLine($"Сумма чисел от {n} до {m} равна:  {SumRec(n,m)} ");
// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int n = ReadData("Введите число N  ");
string NumbersRec(int n, int b)
{
    if(b<=n) return $"{b} , " + NumbersRec(n,b+1);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(n,1));
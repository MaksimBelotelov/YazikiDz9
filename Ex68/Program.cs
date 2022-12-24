// Задача 68. Задайте значения M и N. Напишите программу, которая найдет
// наибольший общий делитель этих чисел с помощью рекурсии.

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Наибольший общий делитель равен: {NOD(m,n)}");

int NOD(int m, int n)
{
    if(m%n!=0) return NOD(n,m%n);
    else return n;
}
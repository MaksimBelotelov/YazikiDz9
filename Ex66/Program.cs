// Задача 66. Задайте значения M и N. Напишите программу, которая найдет
// сумму натуральных элементов в промежутке от M до N c помощью рекурсии

Console.Clear();

Console.Write("Введите число M: ");
int from = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число N: ");
int to = Convert.ToInt32(Console.ReadLine());

Console.Write($"Cумма натуральных чисел от {from} до {to} равна {GetSum(from, to)}");

int GetSum(int from, int to)
{
    if(to>=from) return to+GetSum(from,to-1);
    else return 0;
}

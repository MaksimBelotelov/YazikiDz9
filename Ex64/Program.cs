// Задача 64. Задайте значения M and N. Напишите программу, которая
// выведет все четные натуральные числа в промежутке от M до N 
// с помощью рекурсии

Console.Clear();

Console.Write("Введите число M: ");
int from = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число N: ");
int to = Convert.ToInt32(Console.ReadLine());

if(to%2!=0 && from%2!=0 && to==from)
    Console.Write("Между введенными числами нет чётных натуральных чисел");
else
{
    if(from%2!=0) from++;
    if(to%2!=0) to--;

    Console.Write($"{GetEven(from, to)} ");
}


string GetEven(int m, int n)
{
    if (n > m) return GetEven(m, n-2) + ' ' + n;
    else return Convert.ToString(n);
}

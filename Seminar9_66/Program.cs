// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int l = n - m + 1;
int [] array = Array(l, m, n + 1);
System.Console.WriteLine();

int [] Array(int l, int m, int n)
{
    int[] array = new int[l];
    for (int i = 0; i < l; i++)
    {
        array[i] = m + i;
    }
    return array;
}
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();

static int Sum(int n, int m)
{
    if ((n <= m)) return n;
    else return 
    n + Sum(n - 1, m);
    n--;
}
Console.WriteLine(Sum(n, m));

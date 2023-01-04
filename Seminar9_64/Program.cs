// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine();
int i = 0;
int [] array = GetArray(n, i);
int [] GetArray(int n, int i = 0)
{
   int[] array = new int[n];
    if (i <= n)
    {
        array[i] = n - i;
        i = i + 1;
        GetArray(n - i, i + 1);
        
    }
    else return array;
    return array;
}
System.Console.WriteLine(String.Join(" ", array));
    

Console.WriteLine();

// Напишите программу, которая принимает на вход число N
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("В какую степень возводить числа: ");

int exponent = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

int i = 0;

for (i = 0; i < N; i++)
{
    array[i] = Convert.ToInt32(Math.Pow((i + 1), exponent));
    Console.Write(array[i] + " ");
}


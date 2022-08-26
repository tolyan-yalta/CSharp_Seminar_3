// Программа,  которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Число хранить в типе данных int, решать с помощью арифметических операций 
//(не рассматривая число как тип данных string).
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int [5];

int index = 0;

array[index] = number % 10;

int category_numbers = 1;

for(index = 1; index < 5; index++)
{
    category_numbers = category_numbers * 10;
    array[index] = number / category_numbers % 10;
}
if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Число " + number + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + number + "  не является палиндромом");
}




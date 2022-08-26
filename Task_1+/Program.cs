// Программа,  которая принимает на вход любое число и проверяет, 
// является ли оно палиндромом.
//Число хранить в типе данных int, решать с помощью арифметических операций 
//(не рассматривая число как тип данных string).
Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 10) 
{
    Console.WriteLine("Одноразрядное число не может быть палиндромом по определению");
}
else
{
    int array_length = 2; // Вычисляем длину будущего массива
    int temp = 99;
    while(temp < number)
    {
        if (number > temp)
        {
            array_length++;
        }
        temp = temp * 10 + 9;
    }

    int[] array = new int [array_length];

    int index1 = 0;
    array[index1] = number % 10;

    int category_numbers = 1;   // Заполняем массив цифрами из числа
    for(index1 = 1; index1 < array_length; index1++)
    {
        category_numbers = category_numbers * 10;
        array[index1] = number / category_numbers % 10;
    }

    bool palindrom = true;
    int index2 = 0;             
    int index3 = array_length-1;
    while(index2 < index3)                // Попарно сравниваем цифры
    {
        if(array[index2] == array[index3])
        {
            index2++;
            index3--;
        }
        else
        {
            palindrom = false;
            break;
        }
    }

    if(palindrom == true)
    {
        Console.WriteLine("Число " + number + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + number + "  не является палиндромом");
    }
}

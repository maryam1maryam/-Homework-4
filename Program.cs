// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int Exponent (int value, int exp)
{
    int result = value;
    for (int i = 1; i < exp; i++)    
    {
        result = result * value;
    }
    return result;
}

int value = Prompt("Введите число А > ");
int exp = Prompt("Введите число B (степень в которую необходимо возвести число А) > ");
// int result = Exponent(value, exp);
// System.Console.WriteLine(result);
System.Console.WriteLine(Exponent(value, exp));*/




// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}

int Summ(int value)
{
    int summ = 0;
    while (value / 10 > 0)
    {
        summ = summ + value % 10;
        value = value / 10;
    }
    int result = value + summ;
    return result;
}

int value = Prompt("Введите число > ");
int result = Summ (value);
System.Console.WriteLine($"{value} - > {result}");*/




// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


/*int[] Create(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void DisplayArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}
DisplayArray(Create(8));*/


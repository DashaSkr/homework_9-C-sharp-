// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string MakeNumbers(int number, int end)
{
    if (number == end)
    {
        return number.ToString();
    }
    return (number + ", " + MakeNumbers(number - 1, end));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int number = EnterData("Введите число N: ");
string numbers = MakeNumbers(number, 1);
Console.WriteLine($"N = {number} --> {numbers}");

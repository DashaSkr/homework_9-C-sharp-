//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int MakeSumNumbers(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return (end + MakeSumNumbers(start, end - 1));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int numberM = EnterData("Введите первое число M: ");
int numberN = EnterData("Введите последнее число N: ");
int numbers = MakeSumNumbers(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} --> {numbers}");

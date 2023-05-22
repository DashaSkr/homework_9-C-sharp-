//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int MakeAkkermanNumbers(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return (MakeAkkermanNumbers(m - 1,1));
    }
    return (MakeAkkermanNumbers(m - 1, MakeAkkermanNumbers(m, n-1)));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int numberM = EnterData("Введите число M: ");
int numberN = EnterData("Введите число N: ");

int numbersToAkkerman = MakeAkkermanNumbers(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} --> A(m, n) = {numbersToAkkerman}");

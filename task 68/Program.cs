/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9

*/

Console.Clear();

int[] InData()
{
    int[] segmentNumbers = new int[2];
    var inConsole = "";
    int n;
    for (int i = 0; i < segmentNumbers.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число:");
        inConsole = Console.ReadLine();
        if (int.TryParse(inConsole, out n))
        {
            if (Convert.ToInt32(inConsole) > 0)
                segmentNumbers[i] = Convert.ToInt32(inConsole);
        }
    }
    return segmentNumbers;
}

int AckermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunc(m - 1, 1);
    else return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}
int[] segmentNumbers = InData();
Console.Write($"m = {segmentNumbers[0]}, n = {segmentNumbers[1]} -> A(m,n) = "
 + AckermanFunc(segmentNumbers[0], segmentNumbers[1]));
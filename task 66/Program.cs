/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

void SumNum(int[] segmentNumbers)
{
    int numb = 0;
    Console.Write($"M = {segmentNumbers[0]}; N = {segmentNumbers[1]}. -> ");
    for (int i = segmentNumbers[0]; i <= segmentNumbers[1]; i++)
    {
        numb = numb + i;
    }
    Console.Write(numb);
}
SumNum(InData());

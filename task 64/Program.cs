/*Задача 64: Задайте значения M и N. Напишите программу,
 которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""
*/
Console.Clear();
int[] InData()
{
    int[] segmentNumbers = new int[2];
    var inConsole = "";
    int n;
    for (int i = 0; i < segmentNumbers.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:");
        inConsole = Console.ReadLine();
        if (int.TryParse(inConsole, out n))
        {
            if (Convert.ToInt32(inConsole) > 0)
                segmentNumbers[i] = Convert.ToInt32(inConsole);
        }

    }
    return segmentNumbers;
}

void OutNum(int[] segmentNumbers)
{
    Console.Write($"M = {segmentNumbers[0]}; N = {segmentNumbers[1]}. -> \"\"");
    for (int i = segmentNumbers[0]; i <= segmentNumbers[1]; i++)
    {
        Console.Write(i);
        if (i != segmentNumbers[1])
        {
            Console.Write(",");
        }
    }
    Console.Write("\"\"");
}
OutNum(InData());
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(CalculateSum(number));

int CalculateSum(int sumNumber)
{
    int sumResult = 0;
    while (sumNumber > 0)
    {
        sumResult = sumResult + sumNumber%10;
        sumNumber = sumNumber/10;
    }
    return sumResult;
}
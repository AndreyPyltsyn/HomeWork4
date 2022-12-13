Console.WriteLine("Введите 2 числа");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(result(number1, number2));


int result(int firstNumber, int secondNumber)
{
    int resultFunction = firstNumber;
    for (int i = 1; i < secondNumber; i++)
    {
        resultFunction *= firstNumber;
    }
    return resultFunction;
}
Console.WriteLine("Введите длинну массива");
int count = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимание значение для массива");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для массива");
int max = int.Parse(Console.ReadLine()!);

int[] arrayResult = GenerateArray();
PrintArray(arrayResult);




int[] GenerateArray()
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;

}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

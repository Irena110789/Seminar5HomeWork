// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] RandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for(int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array [i] + " ");
    Console.WriteLine();
}

int ShowOddSum(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    sum += array [i];
    return sum;
}
Console.WriteLine("Input an array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] newArray = RandomArray(size, minValue, maxValue);
ShowArray(newArray);
int result = ShowOddSum(newArray);
Console.WriteLine("Sum of numbers with odd position is: " + result);
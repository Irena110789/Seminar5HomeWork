// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double [] RandomArray(int size, int minValue, int maxValue)
{
    double [] array = new double[size];
    for(int i = 0; i < size; i++)
    array [i] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 1);
    return array;
}
void ShowArray(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array [i] + " ");
    Console.WriteLine();
}
double MinMaxDiff(double [] array)
{
    double diff = 0;
    double min = array [0];
    double max = array [0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array [i] > max)
        min = array [i];
        if(array [i] < min)
        min = array [i];
        diff = max - min;
    }
    return diff;
}
Console.WriteLine("Input an array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double [] newArray = RandomArray(size, minValue, maxValue);
ShowArray(newArray);
double result = Math.Round(MinMaxDiff(newArray), 2);
Console.WriteLine("The difference of min and max value is: " + result);
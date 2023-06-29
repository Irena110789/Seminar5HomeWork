// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray( int size)
{
    int[]array = new int[size];
    for(int i = 0; i < size; i++)
    {
    int minValue = 100;
    int maxValue = 999;
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}
void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

int ShovEvenNumbered(int[] array)
{
    int count = 0;
for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;   
    }
    return count;
}
Console.WriteLine("Input array size ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = RandomArray(size);
int result = ShovEvenNumbered(newArray);
ShowArray(newArray); 
Console.WriteLine("Number of even numbers is " + result);
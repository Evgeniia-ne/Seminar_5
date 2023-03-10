// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] array = new int[SIZE];


int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}    

void sumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;

for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP+= arr[i];
        }
        else
        {
            sumN+= arr[i];
        }
    }

} 

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);

Console.WriteLine('[' + string.Join(", ", array) + ']');
sumPositiveAndNegative(array, out int sumP, out int sumN);
Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");
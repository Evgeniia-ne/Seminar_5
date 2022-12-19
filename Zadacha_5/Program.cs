//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

const int SIZE = 7;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

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

array = FillArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
int[] newArray = new int[SIZE / 2 + SIZE % 2];

    for (int i = 0; i < SIZE / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
if(array.Length % 2 != 0)    
{
    newArray[newArray.Length -1] = array[array.Length / 2];
}
System.Console.WriteLine('[' + string.Join(", ", array) + ']');
System.Console.WriteLine('[' + string.Join(", ", newArray) + ']');
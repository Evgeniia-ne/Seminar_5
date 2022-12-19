// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

const int SIZE = 10;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 999;

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

Console.WriteLine('[' + string.Join(", ", array) + ']');
System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
bool result = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        result = true;
        break;
    }
}
if(result) System.Console.WriteLine("да");
else System.Console.WriteLine("нет");
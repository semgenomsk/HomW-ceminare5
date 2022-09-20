// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] getArray(int size, int lrftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(lrftRange, rightRange + 1);
    }
    return arr;
}

int sumElementsOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] array = getArray(10, 0, 10);
Console.WriteLine(string.Join(", ", array));
int res = sumElementsOddPosition(array);
Console.WriteLine($"Сумма элементов, находящиеся на нечетных позициях = {res}: ");
// Make the positive elements of array negative and opposite. 

int[] generateArray(int size, int minVal = -10, int maxVal = 10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);

    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

void reverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
}

int size = 12;
int minVal = -9;
int maxVal = 9;

int[] arr = generateArray(size, maxVal: 20);
printArray(arr);
reverseArray(arr);
printArray(arr);
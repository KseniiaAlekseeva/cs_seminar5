// Generate the one-dimensional random array of 123 elements.
// Find the number of elements, which are in range [10,99].

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

int checkRange(int minVal, int maxVal, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if ((array[i] >= minVal) && (array[i] <= maxVal)) count++;
    return count;
}

int size = 123;
int minVal = 10;
int maxVal = 99;

int[] arr = generateArray(size, -200, 200);
printArray(arr);

Console.WriteLine($"There are {checkRange(minVal, maxVal, arr)} number of array in range [{minVal},{maxVal}].");

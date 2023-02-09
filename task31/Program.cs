// Generate a 12-elements array of random integer numbers in range [-9,9]. Find the sum of positive and negative numbers. 

int[] generateArray(int size, int minVal, int maxVal)
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


int size = 12;
int minVal = -9;
int maxVal = 9;
int posSum = 0, negSum = 0;

int[] arr = generateArray(size, minVal, maxVal);
printArray(arr);

foreach (int el in arr)
{
    if (el > 0)
        posSum += el;
    else
        negSum += el;
}

Console.WriteLine($"Positive sum = {posSum}, negative sum = {negSum}");
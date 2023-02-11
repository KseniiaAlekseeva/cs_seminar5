// Find the multiplication of pairs of numbers in one-dimensional array. 
// The pais of numbers are first and last element, second and penultimate element, etc.

int[] GenerateArray(int size, int minVal = -10, int maxVal = 10)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

int[] MultPairs(int[] array)
{
    int numPairs = array.Length / 2;
    if (array.Length % 2 != 0) numPairs += 1;

    int[] pairs = new int[numPairs];
    for (int i = 0; i < numPairs; i++)
        pairs[i] = array[i] * array[array.Length - i - 1];

    return pairs;
}

int size = 13;

int[] arr = GenerateArray(size);
PrintArray(arr);

int[] pairs = MultPairs(arr);
PrintArray(pairs);



﻿// Enter an array. Check if the array contains the given number.

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

int getNumber()
{
    int res;
    Console.Write("Enter an integer number: ");
    res = int.Parse(Console.ReadLine());
    return res;
}

bool checkNumber(int num, int[] array)
{
    bool flag = false;
    int i = 0;
    while ((i < array.Length) && (flag == false))
    {
        if (num == array[i])
            flag = true;
        i++;
    }
    return flag;
}

int size = 12;
int num;
bool check;

int[] arr = generateArray(size, maxVal: 5);
printArray(arr);
num = getNumber();
check = checkNumber(num, arr);
if (check) Console.WriteLine($"Number {num} is in array.");
else Console.WriteLine($"Number {num} is not in array.");
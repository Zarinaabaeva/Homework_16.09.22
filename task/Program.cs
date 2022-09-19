
int[,] GenerateArray(int length, int length1)
{
    int[,] myArray = new int[3, 5]
    {
    {2, 3, 15, 98, 87},
    {12, 35, -8, 0, 36},
    {-58, 63, 6, 78, 19}
    };
    return myArray;
}

int maxMinusMinArray(int[,] array)
{
    int max1 = array[0, 0];
    int max2 = array[1, 0];
    int max3 = array[2, 0];
    int min1 = array[0, 0];
    int min2 = array[0, 1];
    int min3 = array[0, 2];
    int min4 = array[0, 3];
    int min5 = array[0, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[0, j] > max1)
            max1 = array[0, j];
        if (array[1, j] > max2)
            max2 = array[1, j];
        if (array[2, j] > max3)
            max3 = array[2, j];
        if (array[i, 0] < min1)
            min1 = array[i, 0];
        if (array[i, 1] < min2)
            min2 = array[i, 1];
        if (array[i, 2] < min3)
            min3 = array[i, 2];
        if (array[i, 3] < min4)
            min4 = array[i, 3];
        if (array[i, 4] < min5)
            min5 = array[i, 4];
    }
    }

    int max = max1 + max2 + max3;
    int min = min1 + min2 + min3 + min4 + min5;
    int MaxMinusMin = max - min;

    return MaxMinusMin;
}

 void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
   
}

void Print(int res)
{
    Console.Write($"Разница между суммой максимумов и суммой минимумов -> {maxMinusMinArray(GenerateArray(3, 5))}");
}
 
PrintArray(GenerateArray(3, 5));
Print(maxMinusMinArray(GenerateArray(3, 5)));

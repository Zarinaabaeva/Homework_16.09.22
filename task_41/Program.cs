
int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length)
{
  int[] array = new int[length]; 
  
  for (int i = 0; i < array.Length; i++)
{
  array[i] = Convert.ToInt32(Console.ReadLine());
}
  return array;
}

int MoreNullArray(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0)
      sum = sum + 1;
  }
  return sum;
}
void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}
int M = Prompt("Введите длину массива и заполните массив: ");
int[] arr1 = GenerateArray(M);
PrintArray(arr1);
int result = MoreNullArray(arr1);
Console.Write($"Вы ввели {result} чисел(число, числа) больше нуля");

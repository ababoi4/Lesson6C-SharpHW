// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3



int[] GenerateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max);
    }
    return answer;
}
void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        Console.Write($"{array[count]} \t");
        count++;
    }
    Console.WriteLine();
}
int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] > 0)
    {
      sum +=1;
      
    }
  }
  return sum;
}

int [] array = GenerateArray(10, -5, 10);
PrintArray(array);
int sum = SumPositive(array);
System.Console.WriteLine($"Количество положительных чисел в массиве равно {sum}");

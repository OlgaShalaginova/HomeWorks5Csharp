// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
FindChetEl(numbers);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("Массив: ");
    Console.Write("[ ");
    for(int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void FindChetEl (int [] numbers)
{
 int count = 0;
 for (int x = 0; x < size; x++)
 if (numbers[x] % 2 == 0)
 count++;
 Console.WriteLine($"Всего {size} чисел, {count} из них чётные");
}
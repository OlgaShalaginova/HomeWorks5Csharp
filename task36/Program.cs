// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
SumElArray(numbers);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
        {
            numbers[i] = new Random().Next(1,10);
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
void SumElArray (int [] numbers)
 {
 int sum = 0;
 for (int x = 0; x < size; x+=2)
    sum = sum + numbers[x];
    Console.WriteLine($"Всего {size} чисел, сумма элементов на нечётных позициях = {sum}");
 }
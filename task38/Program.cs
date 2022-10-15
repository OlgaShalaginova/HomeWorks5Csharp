// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Raznica(numbers);

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < size; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
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
void Raznica(double[] numbers)
{
 double minValue = Int32.MaxValue;
 double maxValue = Int32.MinValue;
 for (int x = 0; x < size; x++)
  {
    if (numbers[x] > maxValue)
        {
            maxValue = numbers[x];
        }
    if (numbers[x] < minValue)
        {
            minValue = numbers[x];
        }
 }
 Console.WriteLine($"Всего {size} чисел. Максимальное значение = {maxValue}, минимальное значение = {minValue}");
 Console.WriteLine($"Разница между максимальным и минимальным значением = {maxValue - minValue}");
}

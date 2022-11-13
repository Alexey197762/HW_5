/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
randomnambers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void randomnambers(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(0,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int x = 0; x < numbers.Length; x++)
    {
        Console.Write(numbers[x] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
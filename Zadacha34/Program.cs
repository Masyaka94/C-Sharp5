/*34. Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве*/

void FillArray(int[] massive)
{
int length = massive.Length;

for (int index = 0; index<length; index++)
{
massive[index]=new Random().Next(100,1000);
}
}

void PrintArray(int[] mass)
{
foreach (int position in mass)
{
Console.Write($"{position} ");
}
}

Console.Write($"Введите размер массива:  ");
int x = int.Parse(Console.ReadLine()!);
int[] array = new int [x];
FillArray(array);
PrintArray(array);
int count = 0;

 for (int i = 0; i<array.Length; i++)
 	{
	if (array [i] % 2 == 0) count ++;
	}
Console.Write($"Количество чётных чисел равно {count}");
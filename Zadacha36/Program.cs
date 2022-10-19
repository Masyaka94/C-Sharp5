/*36. Задайте одномерный массив заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях*/

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
int sum = 0;

 for (int i = 0; i<array.Length; i++)
 	{
	if (i %2 != 0) sum = sum + array [i];
	}
Console.Write($"Сумма чисел, стоящих на нечётных позициях равна {sum}");
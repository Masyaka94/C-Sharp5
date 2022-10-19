/*38. Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива. */

void FillArray(double[] massive)
{
int length = massive.Length;
for (int index = 0; index<length; index++)
{
massive[index]=new Random().Next(100,1000);
}
}

void PrintArray(double[] mass)
{
foreach (int position in mass)
{
Console.Write($"{position} ");
}
}

Console.Write($"Введите размер массива:  ");
int x = int.Parse(Console.ReadLine()!);
double [] array = new double [x];
FillArray(array);
PrintArray(array);
double minPos = array[0];
double maxPos = 0;
double sum = 0;
for (int i = 0; i<array.Length; i++)
   { 
    if (array[i]>maxPos) maxPos = array[i];
    if (array[i]<minPos) minPos = array[i];
    }
sum = maxPos - minPos;
Console.Write($"Разница между максимальным {maxPos} и минимальным {minPos} элементами массива равна: {sum}");
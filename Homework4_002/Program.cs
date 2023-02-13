// Задать массив, заполнить случайными положительными трехзначными числами. 
// Показать количество четных и нечетных чисел.()

Console.Clear();
Console.Write("Введите величину массива - ");
int number=int.Parse(Console.ReadLine()!);
Console.WriteLine();
int []array=new int[number];
int resPositive=0;
int kolPositive=0;
int resNegative=0;
int kolNegative=0;

for (int i=0;i<number; i++)  
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i]+" | ");
}
Console.WriteLine();
for (int i=0;i<number; i++)
{ 
    if (array[i]%2==0) 
    { 
        resPositive=resPositive+array[i];
        kolPositive++;
    }
    else 
    { 
        resNegative=resNegative+array[i];
        kolNegative++;
    }
}

Console.WriteLine();
Console.WriteLine("Четных цифр в массиве "+ kolPositive+" величиной равной "+resPositive);
Console.WriteLine("Нечетных цифр в массиве "+kolNegative+" величиной равной "+resNegative);
Console.WriteLine();
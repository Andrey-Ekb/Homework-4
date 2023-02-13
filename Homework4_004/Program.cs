// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
Console.Write("Введите величину массива - ");
int number=int.Parse(Console.ReadLine()!);
Console.WriteLine();
int []array=new int[number];
int resNegative=0;

for (int i=0;i<number; i++)  
{
    array[i] = new Random().Next(1,10);
    Console.Write(array[i]+" | ");
}
Console.WriteLine();
for (int i=0;i<number; i++)
{ 
    if (array[i]%2>0) resNegative=resNegative+array[i];
}

Console.WriteLine();
Console.WriteLine("Сумма нечетных чисел равна "+resNegative);
Console.WriteLine();


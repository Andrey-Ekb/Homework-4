// В однородном массиве из 123 чисел найти колличество элементов из отрезка [10,99]
Console.Clear();
int[] array = new int[123];
    for (int kol = 0; kol < array.Length; kol++)   
         array[kol] = new Random().Next(0,9);
int i=0;
int min=10;
int max=99;
int length=max-min;
Console.WriteLine();
i=10;
    while (min <=i && i<max)
    {
        Console.Write(" "+array[i]+" |");
        i++;
    }
    i=i-min;
Console.WriteLine();
Console.WriteLine("Количество чисел из диапазона [10, 99] равно "+i);
Console.WriteLine();

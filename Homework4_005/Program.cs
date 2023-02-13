// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
Console.Write("Введите величину массива - ");
int length=int.Parse(Console.ReadLine()!);
int[]array=new int[length];
int kol=length;
Console.WriteLine();

for (int i=0; i<length; i++)
{ 
    array[i]=new Random().Next(1,10);
    Console.Write(array[i]+"  ");
}
Console.WriteLine();
kol=kol/2;
int[]rez=new int[kol];
int last=length-1;

for (int i=0;i<kol; i++)
{ 
    rez[i]=array[i]*array[last];     
    last--;
}
Console.WriteLine();

for (int i=0;i<kol; i++)
    Console.Write(rez[i]+" ");
Console.WriteLine();
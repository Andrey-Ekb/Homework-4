
// Задать массив из восьми элементов, заполненных нулями и единицами. Вывести на экран.
Console.Clear();
Console.WriteLine();

int[]array=new int[8];
int i=0; 
int length=array.Length;

for (i=0; i<length; i++) array[i] = new Random().Next(0,2);

for (i=0; i<length; i++) Console.Write(" "+i+" |");

Console.WriteLine();  

for (i=0; i<length; i++) Console.Write(" "+array[i]+" |");

Console.WriteLine();
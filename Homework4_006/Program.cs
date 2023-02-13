// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();
Console.Write("Введите величину массива - ");
int k=int.Parse(Console.ReadLine()!);
Console.WriteLine();
double min=0;
double max=0;
double dif=0;

double[]array= new double[k];
    for(int i=0; i<k; i++) array[i]=new Random().NextDouble()*100;
   
    for  (int i=0; i<k; i++) Console.Write(array[i].ToString(".00")+"  | ");

Console.WriteLine();

min=array[1];  
    for  (int i=0; i<k; i++)    
          if (min>array[i]) min=array[i];
          
    for  (int i=0; i<k; i++)    
          if (max<array[i]) max=array[i];

dif=max-min;
        
Console.WriteLine();
Console.WriteLine("Минимальное значение массива - "+min.ToString(".00"));
Console.WriteLine("Максимальное значение массива - "+max.ToString(".00"));
Console.WriteLine();
Console.WriteLine("Разница между минимальным и максимальным значениями массива равна - "+dif.ToString(".00"));
Console.WriteLine();
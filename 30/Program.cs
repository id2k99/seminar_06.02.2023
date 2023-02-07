// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
Console.WriteLine("Введите число");
int s = int.Parse(Console.ReadLine());
int [] array = GetBinArray(s);
Console.Write($"[{String.Join(" , ", array)}]");


int [] GetBinArray(int size)
{
    int[] arr = new int [size];
    int i = 0;
    while(i < 8) 
    {
        arr[i] = new Random().Next(0, 2);
        i++;
    }
    return arr;
}



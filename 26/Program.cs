// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Длина числа {NumberLehgth(s)}");

int NumberLehgth(int n)
{   
    int count = 0;
    if(n<0)
    {
        n = n * (-1);
    }

    while (n > 0)
   {
        count ++;
        n = n / 10;
   }
    return count;
}




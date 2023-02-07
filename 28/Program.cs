// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение всех чисел от 1 до n {ProductOfNumbers(s)}");

int ProductOfNumbers(int n)
{
    if (n <0)
    {
        n = n * (-1);
    }
    
    int count = 1;
    int product = 1;
    while (count <= n)
    {
        product = product * count;
        count++;
    }
    return product;
}
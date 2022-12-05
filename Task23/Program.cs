//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите N ");
int N = int.Parse(Console.ReadLine());
if(N>0)
{
    for(int i=1; i<=N; i++)
{
    Console.WriteLine($"{Math.Pow(i, 3)}");
}
}else
{
    for(int i=-1; i>=N; i=i-1)
    {
        Console.WriteLine($"{Math.Pow(i, 3)}");
    }
}


// Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли 
//оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число ");
int N = int.Parse(Console.ReadLine());
int N1 = N/10000;
int N2 = N/1000%10;
int N4 = N/10%10;
int N5 = N%10;
if(N>9999 && N<100000)
{
    if(N1==N5 && N2==N4)
    {
        Console.WriteLine("палиндром");
        }else{
            Console.WriteLine("не палиндром");
        }
}else{
    Console.WriteLine("Введено не пятизначное число");
}

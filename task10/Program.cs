Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 99 || n > 999)
    Console.WriteLine("Число не трехзначное");
else
{
int x;
x = (n / 10) % 10;
Console.WriteLine(x);
}
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("Третьей цифры нет");
int x;
x = (n/100) % 10;
Console.WriteLine(x);
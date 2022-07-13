int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
double dis = x;
int day = 1; // количество дней пробега
while (dis < y)
{
    dis = dis + ((dis /100) * 15);
    day++;
}

if (dis == y || dis > y)
Console.WriteLine(day);


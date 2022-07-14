int x = Convert.ToInt32(Console.ReadLine()); // вклад в банке
int p = Convert.ToInt32(Console.ReadLine()); // на столько процентов увеличивается вклад каждый год
int y = Convert.ToInt32(Console.ReadLine()); //через сколько лет вклад составит У рублей
double m = x;
int t = 0; // через столько лет 
while (m < y)
{
    m = m + ((m/100)*p);
    m =  ((m * 100)- m %100) / 100;
    t ++; 
}
if (m == y || m > y)
Console.WriteLine(t);


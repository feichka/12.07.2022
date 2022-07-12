Console.WriteLine("Введите цифру, соответствующую дню недели");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)
    Console.WriteLine("Это выходной день");
else
{
    if (a > 7)
    Console.WriteLine("Так не бывает");
    if (a < 6)
    Console.WriteLine("это будний день");
}
    
Console.Clear();

Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
int x = num;

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(x != 0)
    {
        x = x / 10;
        count++;
    }
    while(count > 3)
    {
        count--;
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
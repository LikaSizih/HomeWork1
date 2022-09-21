Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int x = 1;

System.Console.WriteLine("Все чётные числа от 1 до " + number);
while (x < number)
{
    if(x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}

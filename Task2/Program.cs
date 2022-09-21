Console.WriteLine("Введите три любых числа");
int number_a = int.Parse(Console.ReadLine());
int number_b = int.Parse(Console.ReadLine());
int number_c = int.Parse(Console.ReadLine());
int max = number_a;

if (number_b > max)
{
    max = number_b;
}
if (number_c > max)
{
    max = number_c;
}
Console.WriteLine("Max = " + max);
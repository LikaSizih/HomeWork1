Console.WriteLine("Введите число а");
int number_a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int number_b = int.Parse(Console.ReadLine());

if (number_a > number_b)
{
    Console.Write("max = ");
    Console.WriteLine(number_a);
    Console.Write("min = ");
    Console.WriteLine(number_b);

}
else
{
    Console.Write("max = ");
    Console.WriteLine(number_b);
    Console.Write("min = ");
    Console.WriteLine(number_a);
}
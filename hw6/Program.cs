Console.WriteLine("Введите число, что бы программа определила является ли оно четным");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число не четное");
}